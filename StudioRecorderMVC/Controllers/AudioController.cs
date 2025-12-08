using Microsoft.AspNetCore.Mvc;

namespace StudioRecorderMVC.Controllers
{
    public class AudioController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile audioFile)
        {
            if (audioFile == null || audioFile.Length == 0)
                return BadRequest("No audio received.");

            var audioFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "audio");
            Directory.CreateDirectory(audioFolder);

            var savePath = Path.Combine(audioFolder, audioFile.FileName);

            using (var stream = new FileStream(savePath, FileMode.Create))
            {
                await audioFile.CopyToAsync(stream);
            }

            return Ok("Audio uploaded successfully.");
        }
    }
}
