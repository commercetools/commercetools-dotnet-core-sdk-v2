using System;
using System.Globalization;
using System.Threading.Tasks;
using Amazon.SQS;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Subscriptions;
using Xunit;
using static commercetools.Api.IntegrationTests.Products.ProductsFixture;

namespace commercetools.Api.IntegrationTests.StandalonePricing
{
    [Collection("Integration Tests")]
    public class SubscriptionTest
    {
        private readonly ProjectApiRoot _projectApiRoot;

        public SubscriptionTest(ServiceProviderFixture serviceProviderFixture)
        {
            this._projectApiRoot = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

 
    
        [Fact]
        public async Task ProductCreated()
        {
            var sqsclient = new AmazonSQSClient();

           var queueCreated = async sqsclient.CreateQueueAsync("dotnet-sdk-test-queue");

           var queueUrl = queueCreated.GetQueueUrl();

           var subscription = await _projectApiRoot.Subscriptions().Post(new SubscriptionDraft()
            {
                Changes = new List<IChangeSubscription>()
                {
                    ResourceTypeId = "product"
                }
            }).ExecuteAsync();
            Assert.NotNull(subscription);
            
            await WithProduct(_projectApiRoot,
                draft => DefaultProductDraftWithMultipleVariants(draft, 2),
                async product =>
                {
                    var sqsMessages = sqsclient.ReceiveMessageAsync(queueUrl);
                    



                }
            );
        }
    }
}