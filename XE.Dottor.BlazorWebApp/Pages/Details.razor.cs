namespace XE.Dottor.BlazorWebApp.Pages
{
    using Microsoft.AspNetCore.Components;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using XE.Dottor.ApplicationCore.Interfaces;
    using XE.Dottor.ApplicationCore.Services;
    using XE.Dottor.BlazorWebApp.Models;
    using XE.Dottor.BlazorWebApp.Services;

    public partial class Details
    {

        [Inject]
        private IApiProxyService ApiProxyService { get; set; }
        [Inject]
        private StateContainer Store { get; set; }
        [Inject]
        private JsFunctionService JsFunctions { get; set; }


        [Parameter] 
        public int Id { get; set; }


        private bool Loading { get; set; }
        private PostViewModel Post { get; set; }
        private IEnumerable<CommentViewModel> Comments { get; set; }


        protected override async Task OnInitializedAsync()
        {
            // recupero li post dallo store, così mi evito di chiamare l'API
            //
            Post = Store.Posts.FirstOrDefault(p => p.Id == Id);

            var comments = await ApiProxyService.GetPostCommentsAsync(Id);

            var temp = new List<CommentViewModel>();
            foreach (var comment in comments)
            {
                temp.Add(new CommentViewModel(comment, await JsFunctions.GetGravatarUrl(comment.Email)));
            }

            Comments = temp;

            Loading = false;
        }
    }
}
