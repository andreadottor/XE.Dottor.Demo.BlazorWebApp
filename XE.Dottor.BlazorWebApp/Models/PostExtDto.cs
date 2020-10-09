namespace XE.Dottor.BlazorWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PostExtDto
    {
        public int likes { get; set; }
        public IEnumerable<string> hashtags { get; set; }
    }
}
