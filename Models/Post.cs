using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322FinalProject.Models
{
    public class Post
    {

        public int Id { get; set; }

        [StringLength(512, MinimumLength = 3)]
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; } // nvarchar(512), not nullable

        [StringLength(512, MinimumLength = 3)]
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; } // nvarchar(512), not nullable

        [StringLength(512, MinimumLength = 3)]
        [Required]
        [Display(Name = "Content")]
        public string Content { get; set; } // nvarchar(512), not nullable

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual List<Comment> Comments { get; set; }

        public virtual List<PostImage> PostImages { get; set; }
    }
}