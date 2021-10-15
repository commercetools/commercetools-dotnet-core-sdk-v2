using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Categories
{
    public partial class ByProjectKeyCategoriesByIDPost : ApiMethod<ByProjectKeyCategoriesByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Api.Models.Categories.ICategoryUpdate CategoryUpdate;

        public ByProjectKeyCategoriesByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Api.Models.Categories.ICategoryUpdate categoryUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.CategoryUpdate = categoryUpdate;
            this.RequestUrl = $"/{ProjectKey}/categories/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCategoriesByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Api.Models.Categories.ICategory> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Categories.ICategory>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(CategoryUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
