using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322FinalProject.Models
{
    public class GalleryImage
    {

        public int Id { get; set; }
        public int GalleryId { get; set; }
        public string FileName { get; set; }
        public bool IsDefaultImage { get; set; }
        public virtual Gallery Gallery { get; set; }

    }
}