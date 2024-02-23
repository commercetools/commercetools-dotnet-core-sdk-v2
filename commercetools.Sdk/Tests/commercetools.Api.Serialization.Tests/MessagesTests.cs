using System.Collections.Generic;
using System.IO;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Subscriptions;
using commercetools.Base.Serialization;
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
            var messages = serializerService.Deserialize<List<IMessage>>(serialized);
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
            var messages = serializerService.Deserialize<List<IMessage>>(serialized);
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
            var messages = serializerService.Deserialize<List<IMessage>>(serialized);
            Assert.Single(messages);
            var reviewMessage = messages[0];
            Assert.IsAssignableFrom<IMessage>(reviewMessage);
            Assert.IsType<ReviewCreatedMessage>(reviewMessage);
        }

        [Fact]
        public void MessagesDeserializationToGeneralMessage()
        {
            //Deserialize 1 of messages as general message (when the message type not in the SDK)
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/ReviewMessages.json");
            var messages = serializerService.Deserialize<List<IMessage>>(serialized);
            Assert.Single(messages);
            var generalMessage = messages[0];
            Assert.NotNull(generalMessage.Type);
        }

        [Fact]
        public void DeserializationOfResourceCreatedDelivery()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/ResourceCreatedPayload.json");
            var payload = serializerService.Deserialize<IDeliveryPayload>(serialized);
            Assert.NotNull(payload);
            Assert.NotNull(payload.ResourceUserProvidedIdentifiers);
            Assert.Equal("test-ca15403ea56ec0e51137ff40a6f4607e", payload.ResourceUserProvidedIdentifiers.Key);
            Assert.IsType<ResourceCreatedDeliveryPayload>(payload);
            var customerCreatedPayload = payload as ResourceCreatedDeliveryPayload;
            Assert.NotNull(customerCreatedPayload);
            Assert.NotNull(customerCreatedPayload.Resource);
            Assert.IsType<CustomerReference>(customerCreatedPayload.Resource);
            Assert.Equal("e63d76ff-e203-42ba-af17-375040b8ecb6", customerCreatedPayload.Resource.Id);
        }

        [Fact]
        public void DeserializationOfListOfSubscriptionDelivery()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/Payloads.json");
            var payloads = serializerService.Deserialize<List<IDeliveryPayload>>(serialized);
            Assert.NotNull(payloads);
            Assert.Equal(4, payloads.Count);
            var resourceCreatedPayload = payloads[0] as ResourceCreatedDeliveryPayload;
            var resourceUpdatedPayload = payloads[1] as ResourceUpdatedDeliveryPayload;
            var resourceDeletedPayload = payloads[2] as ResourceDeletedDeliveryPayload;
            var customerCreatedPayload = payloads[3] as MessageDeliveryPayload;

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
            var payload = serializerService.Deserialize<IDeliveryPayload>(serialized);
            Assert.NotNull(payload);
            var categoryCreatedPayload = payload as MessageDeliveryPayload;
            Assert.NotNull(categoryCreatedPayload);
            Assert.Equal(expectedCategoryId, categoryCreatedPayload.Resource.Id);
            var categoryCreatedMessage = serializerService.Deserialize<CategoryCreatedMessage>(serialized);
            Assert.NotNull(categoryCreatedMessage);
            Assert.Equal(expectedCategoryId, categoryCreatedMessage.Category.Id);
        }

        [Fact]
        public void DeserializationOfListOfMessageSubscriptionPayloads()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/MessageSubscriptionPayloads.json");
            var payloads = serializerService.Deserialize<List<IMessage>>(serialized);
            Assert.NotNull(payloads);
            Assert.IsType<CategoryCreatedMessage>(payloads[0]);
            Assert.IsType<CustomerCreatedMessage>(payloads[1]);
        }

        [Fact]
        public void DeserializationOfListOfSubscriptionDeliveryUnwrapped()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/Payloads.json");
            var payloads = serializerService.Deserialize<List<IDeliveryPayload>>(serialized);
            Assert.NotNull(payloads);
            Assert.Equal(4, payloads.Count);
            var resourceCreatedPayload = payloads[0] as ResourceCreatedDeliveryPayload;
            var resourceUpdatedPayload = payloads[1] as ResourceUpdatedDeliveryPayload;
            var resourceDeletedPayload = payloads[2] as ResourceDeletedDeliveryPayload;
            var customerCreatedPayload = payloads[3] as MessageDeliveryPayload;

            Assert.NotNull(resourceCreatedPayload);
            Assert.NotNull(resourceUpdatedPayload);
            Assert.NotNull(resourceDeletedPayload);
            Assert.NotNull(customerCreatedPayload);
            Assert.Equal(2, resourceUpdatedPayload.OldVersion);
            Assert.IsType<CustomerCreatedMessage>(customerCreatedPayload.Message);
        }

        [Fact]
        public void DeserializationOfListOfMessageSubscriptionPayloadsUnwrapped()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/MessageSubscriptionPayloads.json");
            var payloads = serializerService.Deserialize<List<IDeliveryPayload>>(serialized);
            Assert.NotNull(payloads);
            Assert.IsType<MessageDeliveryPayload>(payloads[0]);
            Assert.IsType<MessageDeliveryPayload>(payloads[1]);
            Assert.IsType<CategoryCreatedMessage>((payloads[0] as IMessageDelivery).Message);
            Assert.IsType<CustomerCreatedMessage>((payloads[1] as IMessageDelivery).Message);

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
            Assert.Equal("cart-discount", changeSubscription1.ResourceTypeId.ToString());
            Assert.Equal("new-type", changeSubscription2.ResourceTypeId.ToString());
        }

        [Fact]
        public void DeserializeOfSubscriptions()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Messages/Subscriptions.json");
            var subscriptions = serializerService.Deserialize<List<Subscription>>(serialized);
            Assert.Equal(2, subscriptions.Count);
            Assert.IsType<SqsDestination>(subscriptions[0].Destination);
            Assert.IsType<SnsDestination>(subscriptions[1].Destination);
            var subscription1 = subscriptions[0];
            var subscription2 = subscriptions[1];
            Assert.IsType<PlatformFormat>(subscription1.Format);
            var subscription2Format = subscription2.Format as CloudEventsFormat;
            Assert.NotNull(subscription2Format);
            Assert.Equal("0.1", subscription2Format.CloudEventsVersion);
            Assert.NotNull(subscription1.Status.Value);
            Assert.NotNull(subscription2.Status.Value);
            Assert.Equal(SubscriptionHealthStatus.Healthy, subscription1.Status.Value);
            Assert.Equal(SubscriptionHealthStatus.TemporaryError, subscription2.Status.Value);
            Assert.Single(subscription1.Messages);
            Assert.Single(subscription2.Changes);
        }

        [Fact]
        public void DeserializeMessagePayloads()
        {
            var serializerService = this.serializationFixture.SerializerService;

            string serialized1 = @"
                {
                    ""type"": ""CategoryCreated""
                }
            ";
            string serialized2 = @"
                {
                    ""type"": ""new-type""
                }
            ";

            var payload1 = serializerService.Deserialize<IMessagePayload>(serialized1);
            var payload2 = serializerService.Deserialize<IMessagePayload>(serialized2);
            Assert.IsType<CategoryCreatedMessagePayload>(payload1);
            Assert.IsType<MessagePayload>(payload2);
        }

    }
}