using Cet322FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322FinalProject.ViewModel
{
    public class HomePageViewModel
    {

        public List<Post> Posts { get; set; }

        public List<Gallery> Gallery { get; set; }
    }
}