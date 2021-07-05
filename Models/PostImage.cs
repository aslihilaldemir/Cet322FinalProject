using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322FinalProject.Models
{
    public class PostImage
    {

        public int Id { get; set; }
        public int PostId { get; set; }
        public string FileName { get; set; }
        public bool IsDefaultImage { get; set; }
        public virtual Post Post { get; set; }

    }
}