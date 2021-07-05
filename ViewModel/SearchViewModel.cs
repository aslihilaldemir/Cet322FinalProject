using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322FinalProject.ViewModel
{
    public class SearchViewModel
    {
        [Display(Name = "Arama Metni")]
        public string SearchText { get; set; }
        [Display(Name = "Açıklamalarda Ara")]
        public bool SearchInDescription { get; set; }
        [Display(Name = "Kategori Seçimi")]
        public int? CategoryId { get; set; }

        public int? MaximumPrice { get; set; }
        public List<Models.Post> Results { get; set; }
    }
}