using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EvTecnicaGyS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        public readonly IAmazonS3 _amazons3;
        public ImageController(IAmazonS3 amazons3)
        {
            _amazons3 = amazons3;
        }

        // POST api/Image
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] IFormFile formFile)
        {
            var putRequest = new PutObjectRequest()
            {
                BucketName = "BucketName",   //Here Name of the Bucket S3
                Key = formFile.FileName,
                InputStream = formFile.OpenReadStream(),
                ContentType = formFile.ContentType,
            };
            var result = await _amazons3.PutObjectAsync(putRequest);
            return Ok(result);
        }
    }
}
