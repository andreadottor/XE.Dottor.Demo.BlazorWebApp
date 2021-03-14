namespace XE.Dottor.ApplicationCore.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Threading.Tasks;
    using XE.Dottor.ApplicationCore.Interfaces;
    using XE.Dottor.ApplicationCore.Models;

    public class JSONPlaceholderApiProxyService : IApiProxyService
    {
        private readonly HttpClient _http;

        public JSONPlaceholderApiProxyService(HttpClient http) => _http = http;

        public Task<IEnumerable<PostDto>> GetPostListAsync()
        {
            return _http.GetFromJsonAsync<IEnumerable<PostDto>>("https://jsonplaceholder.typicode.com/posts");
        }

        public Task<IEnumerable<PostDto>> GetPostListAsync(int userId)
        {
            return _http.GetFromJsonAsync<IEnumerable<PostDto>>($"https://jsonplaceholder.typicode.com/posts?userId={userId}");
        }

        public Task<IEnumerable<CommentDto>> GetPostCommentsAsync(int postId)
        {
            return _http.GetFromJsonAsync<IEnumerable<CommentDto>>($"https://jsonplaceholder.typicode.com/posts/{postId}/comments");
        }

        public async Task<UserDto> GetUserAsync(string userName)
        {
            var users = await _http.GetFromJsonAsync<IEnumerable<UserDto>>($"https://jsonplaceholder.typicode.com/users?username={userName}");
            if (users.Any())
                return users.FirstOrDefault();

            return null;
        }
    }
}
