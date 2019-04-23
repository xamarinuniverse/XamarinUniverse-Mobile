using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WordPressRestApiStandard;
using WordPressRestApiStandard.Models;
using WordPressRestApiStandard.QueryModel;

namespace XamarinUniverse.Mobile.Services
{
    //documentation for features implementations
    //https://wbsimms.github.io/WordPressRestApi/

    public class WordPressService
    {
        private readonly WordPressApiClient _client;
        
        public WordPressService()
        {
            _client = new WordPressApiClient("http://juegosmental.es/wp-json/wp/v2");
            //new WordPressApiClient(Statics.WordpressUrl);
        }

        public async Task<List<Post>> GetLatestPostAsync(int perPage = 10)
        {
            List<Post> result;
            var query = new PostsQuery { PerPage = perPage };

            result = await _client.GetPosts(query);                  

            return result;
        }
    }
}
