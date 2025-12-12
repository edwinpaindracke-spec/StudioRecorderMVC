using Microsoft.AspNetCore.Mvc;

namespace YourApp.Controllers
{
    public class UploadController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> UploadBeat(IFormFile beatFile)
        {
            if (beatFile == null || beatFile.Length == 0)
                return BadRequest("No file");

            var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

            if (!Directory.Exists(uploads))
                Directory.CreateDirectory(uploads);

            var filePath = Path.Combine(uploads, beatFile.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await beatFile.CopyToAsync(stream);
            }

            // Return the relative path so browser can play it
            return Ok("/uploads/" + beatFile.FileName);
        }
    }
}
