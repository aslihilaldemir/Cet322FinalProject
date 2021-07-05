using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322FinalProject.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual List<GalleryImage> GalleryImages { get; set; }

    }
}