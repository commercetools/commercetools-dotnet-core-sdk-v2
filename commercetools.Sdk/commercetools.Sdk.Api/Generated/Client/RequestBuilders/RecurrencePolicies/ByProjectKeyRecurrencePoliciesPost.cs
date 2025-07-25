using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.RecurrencePolicies
{

    public partial class ByProjectKeyRecurrencePoliciesPost : ApiMethod<ByProjectKeyRecurrencePoliciesPost>, IApiMethod<ByProjectKeyRecurrencePoliciesPost, commercetools.Sdk.Api.Models.RecurrencePolicies.IRecurrencePolicy>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyRecurrencePoliciesPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyRecurrencePoliciesPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyRecurrencePoliciesPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.RecurrencePolicies.IRecurrencePolicyDraft RecurrencePolicyDraft;

        public ByProjectKeyRecurrencePoliciesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.RecurrencePolicies.IRecurrencePolicyDraft recurrencePolicyDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.RecurrencePolicyDraft = recurrencePolicyDraft;
            this.RequestUrl = $"/{ProjectKey}/recurrence-policies";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyRecurrencePoliciesPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.RecurrencePolicies.IRecurrencePolicy> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.RecurrencePolicies.IRecurrencePolicy>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.RecurrencePolicies.IRecurrencePolicy>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.RecurrencePolicies.IRecurrencePolicy>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(RecurrencePolicyDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
