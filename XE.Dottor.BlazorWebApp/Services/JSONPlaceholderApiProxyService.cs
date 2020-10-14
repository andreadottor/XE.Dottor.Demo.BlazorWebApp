﻿namespace XE.Dottor.BlazorWebApp.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Threading.Tasks;
    using XE.Dottor.BlazorWebApp.Models;

    public class JSONPlaceholderApiProxyService
    {
        private readonly HttpClient _http;

        public JSONPlaceholderApiProxyService(HttpClient http) => _http = http;


        public async Task<IEnumerable<PostDto>> GetPostList()
        {
            return await _http.GetFromJsonAsync<IEnumerable<PostDto>>("https://jsonplaceholder.typicode.com/posts");
        }

        public async Task<IEnumerable<CommentDto>> GetPostComments(int postId)
        {
            return await _http.GetFromJsonAsync<IEnumerable<CommentDto>>($"https://jsonplaceholder.typicode.com/posts/{postId}/comments");
        }
    }
}
