using System.Collections.Generic;
using System.Linq;
using MyFace.Models.Database;

namespace MyFace.Models.View
{
    public class PostsViewModel
    {
        public int CurrentPageNumber {get;}
        public IEnumerable<PostViewModel> Posts { get; }  

        public PostsViewModel(IEnumerable<Post> posts, int currentPageNumber)
        {
            Posts = posts.Select(post => new PostViewModel(post));
            CurrentPageNumber = currentPageNumber;
            

        }
    }
}