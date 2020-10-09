namespace XE.Dottor.BlazorWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CommentViewModel : CommentDto
    {

        public CommentViewModel()
        {

        }

        public CommentViewModel(CommentDto comment, string gravatarUrl)
        {
            this.Body = comment.Body;
            this.Email = comment.Email;
            this.Name = comment.Name;
            this.GravatarUrl = gravatarUrl;
        }

        public string GravatarUrl { get; set; }
    }
}
