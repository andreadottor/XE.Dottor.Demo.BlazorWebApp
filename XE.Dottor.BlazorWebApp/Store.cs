namespace XE.Dottor.BlazorWebApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using XE.Dottor.BlazorWebApp.Models;

    public class Store
    {

        public Store()
        {
            Posts = Enumerable.Empty<PostViewModel>();
        }

        public IEnumerable<PostViewModel> Posts { get; set; }
    }
    
}
