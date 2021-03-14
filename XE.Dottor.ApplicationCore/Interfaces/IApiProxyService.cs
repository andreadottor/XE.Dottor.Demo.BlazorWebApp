namespace XE.Dottor.ApplicationCore.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using XE.Dottor.ApplicationCore.Models;

    public interface IApiProxyService
    {
        Task<IEnumerable<PostDto>> GetPostListAsync();

        Task<IEnumerable<PostDto>> GetPostListAsync(int userId);

        Task<IEnumerable<CommentDto>> GetPostCommentsAsync(int postId);

        Task<UserDto> GetUserAsync(string userName);
    }
}
