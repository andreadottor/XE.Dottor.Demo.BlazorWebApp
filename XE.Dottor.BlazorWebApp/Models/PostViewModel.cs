namespace XE.Dottor.BlazorWebApp.Models
{
    using System.Collections.Generic;
    using XE.Dottor.ApplicationCore.Models;

    public class PostViewModel : PostDto
    {
        public PostViewModel()
        {
            Tags = new List<string>();
        }

        public PostViewModel(PostDto post)
            : this()
        {
            this.Id = post.Id;
            this.Body = post.Body;
            this.Title = post.Title;
            this.UserId = post.UserId;
        }
        public PostViewModel(PostDto post, PostExtDto ext)
           : this(post)
        {
            this.Likes = ext.Likes;
            this.Tags = ext.Hashtags;
        }

        public int Likes { get; set; }

        public IEnumerable<string> Tags { get; set; }
    }
}
