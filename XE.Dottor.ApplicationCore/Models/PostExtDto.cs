namespace XE.Dottor.ApplicationCore.Models
{
    using System.Collections.Generic;

    public class PostExtDto
    {
        public int Likes { get; set; }
        public IEnumerable<string> Hashtags { get; set; }
    }
}
