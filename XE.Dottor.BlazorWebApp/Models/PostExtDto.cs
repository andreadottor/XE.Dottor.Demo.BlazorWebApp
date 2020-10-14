namespace XE.Dottor.BlazorWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PostExtDto
    {
        public int Likes { get; set; }
        public IEnumerable<string> Hashtags { get; set; }
    }
}
