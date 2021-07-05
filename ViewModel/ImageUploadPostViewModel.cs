using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322FinalProject.ViewModel
{
    public class ImageUploadPostViewModel
    {
        public int PostId { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
