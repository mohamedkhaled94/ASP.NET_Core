using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core.Models;

namespace ASP.NET_Core.ViewModels
{
    public class HomeViewModel
    {
        public List<Pie> Pies { get; set; }
        public string Title { get; set; }

    }
}
