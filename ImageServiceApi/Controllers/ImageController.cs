using ImageServiceApi.Dtos;
using ImageServiceApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ImageServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private IPhotoService _photoService;

        public ImageController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        // POST api/<ImageController>
        [HttpPost]
        public IActionResult Post()
        {

            var file = Request.Form.Files.GetFile("file");

            if (file != null && file.Length > 0)
            {
                // Process the uploaded file
                // For example, you can save it to disk
                var filePath = "path/to/save/file.txt";
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                // Perform any other necessary operations with the file

                return Ok(new { message = "File uploaded successfully" });
            }

            return BadRequest(new { message = "No file received" });
        }

    }
}
