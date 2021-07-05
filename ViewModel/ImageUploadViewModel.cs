using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322FinalProject.ViewModel
{
    public class ImageUploadViewModel
    {

        public int GalleryId { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}