using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.PaymentIntents
{

    public partial class ByProjectKeyPaymentIntentsByPaymentIdPost : ApiMethod<ByProjectKeyPaymentIntentsByPaymentIdPost>, IApiMethod<ByProjectKeyPaymentIntentsByPaymentIdPost, Object>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_manage_paymentsTrait<ByProjectKeyPaymentIntentsByPaymentIdPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string PaymentId { get; }

        private commercetools.Sdk.CheckoutApi.Models.PaymentIntents.IPaymentIntent PaymentIntent;

        public ByProjectKeyPaymentIntentsByPaymentIdPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string paymentId, commercetools.Sdk.CheckoutApi.Models.PaymentIntents.IPaymentIntent paymentIntent)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.PaymentId = paymentId;
            this.PaymentIntent = paymentIntent;
            this.RequestUrl = $"/{ProjectKey}/payment-intents/{PaymentId}";
        }




        public async Task<Object> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<Object>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<Object>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<Object>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(PaymentIntent);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
