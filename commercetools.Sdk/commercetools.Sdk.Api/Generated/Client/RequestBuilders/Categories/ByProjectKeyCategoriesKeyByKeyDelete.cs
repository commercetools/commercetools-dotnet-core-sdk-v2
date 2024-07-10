using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Categories
{

    public partial class ByProjectKeyCategoriesKeyByKeyDelete : ApiMethod<ByProjectKeyCategoriesKeyByKeyDelete>, IApiMethod<ByProjectKeyCategoriesKeyByKeyDelete, commercetools.Sdk.Api.Models.Categories.ICategory>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyCategoriesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyCategoriesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCategoriesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCategoriesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCategoriesKeyByKeyDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyCategoriesKeyByKeyDelete(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/categories/key={Key}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCategoriesKeyByKeyDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyCategoriesKeyByKeyDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Categories.ICategory> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Categories.ICategory>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Categories.ICategory>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Categories.ICategory>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
