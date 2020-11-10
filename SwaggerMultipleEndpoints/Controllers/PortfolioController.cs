using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SwaggerMultipleEndpoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Portfolio")]
    public class PortfolioController : ControllerBase
    {
        private static List<Image> images = new List<Image>() {
        new Image(1, "sunset", "a/path"),
        new Image(1, "cat", "second/path")
        };

        [HttpGet]
        public IEnumerable<Image> Get()
        {
            return images;
        }
    }


    public class Image
    {
        public Image(int id, string name, string imagepath)
        {
            Id = id;
            Name = name;
            ImagePath = imagepath;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string ImagePath { get; private set; }
    }
}
