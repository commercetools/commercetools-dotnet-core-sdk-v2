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
namespace commercetools.Sdk.Api.Client.RequestBuilders.CustomObjects
{

    public partial class ByProjectKeyCustomObjectsByContainerByKeyDelete : ApiMethod<ByProjectKeyCustomObjectsByContainerByKeyDelete>, IApiMethod<ByProjectKeyCustomObjectsByContainerByKeyDelete, commercetools.Sdk.Api.Models.CustomObjects.ICustomObject>, commercetools.Sdk.Api.Client.IDataerasureTrait<ByProjectKeyCustomObjectsByContainerByKeyDelete>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyCustomObjectsByContainerByKeyDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyCustomObjectsByContainerByKeyDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomObjectsByContainerByKeyDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCustomObjectsByContainerByKeyDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string Container { get; }

        private string Key { get; }


        public ByProjectKeyCustomObjectsByContainerByKeyDelete(IClient apiHttpClient, string projectKey, string container, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Container = container;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/custom-objects/{Container}/{Key}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public List<string> GetDataErasure()
        {
            return this.GetQueryParam("dataErasure");
        }

        public ByProjectKeyCustomObjectsByContainerByKeyDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyCustomObjectsByContainerByKeyDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyCustomObjectsByContainerByKeyDelete WithDataErasure(bool dataErasure)
        {
            return this.AddQueryParam("dataErasure", dataErasure.ToString());
        }


        public async Task<commercetools.Sdk.Api.Models.CustomObjects.ICustomObject> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.CustomObjects.ICustomObject>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.CustomObjects.ICustomObject>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.CustomObjects.ICustomObject>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
