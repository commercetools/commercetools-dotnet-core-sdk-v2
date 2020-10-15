using System.Collections.Generic;
using System.IO;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Subscriptions;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class MessagesTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture serializationFixture;

        public MessagesTests(SerializationFixture serializationFixture)
        {
            this.serializationFixture = serializationFixture;
        }

        [Fact]
        public void MessagesDeserializationOfSpecificType()
        {
            //Deserialize 2 of messages of type category to list of Message<Category>
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/CategoryMessages.json");
            var messages = serializerService.Deserialize<List<Message>>(serialized);
            var categoryCreatedMessage = messages[0] as CategoryCreatedMessage;
            var categorySlugChangedMessage = messages[1] as CategorySlugChangedMessage;
            Assert.NotNull(categoryCreatedMessage);
            Assert.NotNull(categoryCreatedMessage.Category);
            Assert.NotNull(categoryCreatedMessage.Resource);
            Assert.NotNull(categorySlugChangedMessage);
            Assert.NotNull(categorySlugChangedMessage.Slug);
        }
        
        [Fact]
        public void MessagesDeserializationOfDifferentTypes()
        {
            //Deserialize 3 of messages of different types
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/Messages.json");
            var messages = serializerService.Deserialize<List<Message>>(serialized);
            var categoryCreatedMessage = messages[0] as CategoryCreatedMessage;
            var customerCreatedMessage = messages[1] as CustomerCreatedMessage;
            var lineItemStateTransitionMessage = messages[2] as LineItemStateTransitionMessage;

            Assert.NotNull(categoryCreatedMessage);
            Assert.NotNull(categoryCreatedMessage.Category);

            Assert.NotNull(customerCreatedMessage);
            Assert.NotNull(customerCreatedMessage.Customer);

            Assert.NotNull(lineItemStateTransitionMessage);
        }

        [Fact]
        public void MessagesDeserializationOfReview()
        {
            //Deserialize 1 of messages of type category to list of Message<Review>
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/ReviewMessages.json");
            var messages = serializerService.Deserialize<List<Message>>(serialized);
            Assert.Single(messages);
            var reviewMessage = messages[0];
            Assert.IsAssignableFrom<Message>(reviewMessage);
            Assert.IsType<ReviewCreatedMessage>(reviewMessage);
        }

        [Fact]
        public void MessagesDeserializationToGeneralMessage()
        {
            //Deserialize 1 of messages as general message (when the message type not in the SDK)
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/ReviewMessages.json");
            var messages = serializerService.Deserialize<List<Message>>(serialized);
            Assert.Single(messages);
            var generalMessage = messages[0];
            Assert.NotNull(generalMessage.Type);
        }
        
        [Fact]
        public void DeserializationOfResourceCreatedDelivery()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/ResourceCreatedPayload.json");
            var payload = serializerService.Deserialize<SubscriptionDelivery>(serialized);
            Assert.NotNull(payload);
            Assert.NotNull(payload.ResourceUserProvidedIdentifiers);
            Assert.Equal("test-ca15403ea56ec0e51137ff40a6f4607e", payload.ResourceUserProvidedIdentifiers.Key);
            Assert.IsType<ResourceCreatedDelivery>(payload);
            var customerCreatedPayload = payload as ResourceCreatedDelivery;
            Assert.NotNull(customerCreatedPayload);
            Assert.NotNull(customerCreatedPayload.Resource);
            Assert.IsType<CustomerReference>(customerCreatedPayload.Resource);
            Assert.Equal("e63d76ff-e203-42ba-af17-375040b8ecb6",customerCreatedPayload.Resource.Id);
        }
        
        [Fact]
        public void DeserializationOfListOfSubscriptionDelivery()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/Payloads.json");
            var payloads = serializerService.Deserialize<List<SubscriptionDelivery>>(serialized);
            Assert.NotNull(payloads);
            Assert.Equal(4, payloads.Count);
            var resourceCreatedPayload = payloads[0] as ResourceCreatedDelivery;
            var resourceUpdatedPayload = payloads[1] as ResourceUpdatedDelivery;
            var resourceDeletedPayload = payloads[2] as ResourceDeletedDelivery;
            var customerCreatedPayload = payloads[3] as MessageDelivery;

            Assert.NotNull(resourceCreatedPayload);
            Assert.NotNull(resourceUpdatedPayload);
            Assert.NotNull(resourceDeletedPayload);
            Assert.NotNull(customerCreatedPayload);
            Assert.Equal(2, resourceUpdatedPayload.OldVersion);
        }

        [Fact]
        public void DeserializationOfListOfMessageSubscriptionPayload()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            var expectedCategoryId = "3df866bd-7e5f-47d1-bbe2-ca1d1f39a260";
            string serialized = File.ReadAllText("Resources/Messages/MessageSubscriptionPayload.json");
            var payload = serializerService.Deserialize<SubscriptionDelivery>(serialized);
            Assert.NotNull(payload);
            var categoryCreatedPayload = payload as MessageDelivery;
            Assert.NotNull(categoryCreatedPayload);
            Assert.Equal(expectedCategoryId, categoryCreatedPayload.Resource.Id);
            var categoryCreatedMessage = serializerService.Deserialize<CategoryCreatedMessage>(serialized);
            Assert.NotNull(categoryCreatedMessage);
            Assert.Equal(expectedCategoryId,categoryCreatedMessage.Category.Id);
        }

        [Fact]
        public void DeserializationOfListOfMessageSubscriptionPayloads()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/MessageSubscriptionPayloads.json");
            var payloads = serializerService.Deserialize<List<Message>>(serialized);
            Assert.NotNull(payloads);
            Assert.IsType<CategoryCreatedMessage>(payloads[0]);
            Assert.IsType<CustomerCreatedMessage>(payloads[1]);
        }

        [Fact]
        public void DeserializeChangeSubscription()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            string serialized1 = @"
                {
                    ""resourceTypeId"": ""cart-discount""
                }
            ";
            string serialized2 = @"
                {
                    ""resourceTypeId"": ""new-type""
                }
            ";

            var changeSubscription1 = serializerService.Deserialize<ChangeSubscription>(serialized1);
            var changeSubscription2 = serializerService.Deserialize<ChangeSubscription>(serialized2);
            Assert.Equal("cart-discount", changeSubscription1.ResourceTypeId);
            Assert.Equal("new-type", changeSubscription2.ResourceTypeId);
        }

        
        [Fact]
        public void DeserializeOfSubscriptions()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/Subscriptions.json");
            var subscriptions = serializerService.Deserialize<List<Subscription>>(serialized);
            Assert.Equal(2,subscriptions.Count);
            Assert.IsType<SqsDestination>(subscriptions[0].Destination);
            Assert.IsType<SnsDestination>(subscriptions[1].Destination);
            var subscription1 = subscriptions[0];
            var subscription2 = subscriptions[1];
            Assert.IsType<DeliveryPlatformFormat>(subscription1.Format);
            var subscription2Format = subscription2.Format as DeliveryCloudEventsFormat;
            Assert.NotNull(subscription2Format);
            Assert.Equal("0.1", subscription2Format.CloudEventsVersion);
            Assert.Equal(SubscriptionHealthStatus.Healthy, subscription1.StatusAsEnum);
            Assert.Equal(SubscriptionHealthStatus.TemporaryError, subscription2.StatusAsEnum);
            Assert.Single(subscription1.Messages);
            Assert.Single(subscription2.Changes);
        }

    }
}