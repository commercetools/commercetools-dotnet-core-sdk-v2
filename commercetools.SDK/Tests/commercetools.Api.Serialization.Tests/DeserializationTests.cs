using System;
using System.IO;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.Projects;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.States;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class DeserializationTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture serializationFixture;

        public DeserializationTests(SerializationFixture serializationFixture)
        {
            this.serializationFixture = serializationFixture;
        }
        
        [Fact]
        public void TestProjectDeserialization()
        {
            //arrange
            var projectResponse = File.ReadAllText("Resources/project.json");
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            //act
            var project = serializerService.Deserialize<Project>(projectResponse);

            //assert
            Assert.NotNull(project);
            Assert.NotNull(project.ShippingRateInputType);
            Assert.IsType<CartScoreType>(project.ShippingRateInputType);
        }
        
        [Fact]
        public void DeserializeLocalizedString()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            string serialized = @"
                {
                    ""name"": {
                        ""en"": ""name-en"",
                        ""en-US"": ""name-en-us""
                    }
                }
            ";

            var product = serializerService.Deserialize<ProductProjection>(serialized);

            Assert.Equal("name-en", product.Name["en"]);
            Assert.Equal("name-en-us", product.Name["en-US"]);
        }
        
        [Fact]
        public void DeserializeShippingMethod()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            var serialized = File.ReadAllText("Resources/ShippingMethods/ShippingMethod.json");

            var shippingMethod = serializerService.Deserialize<ShippingMethod>(serialized);

            Assert.NotNull(shippingMethod);
            Assert.NotNull(shippingMethod.TaxCategory);
            var taxCategoryRef = shippingMethod.TaxCategory;
            Assert.NotNull(taxCategoryRef.Obj);
            Assert.Equal("3d018013-b53d-422a-933c-7294cf114323", taxCategoryRef.Obj.Id);
            Assert.Equal(ReferenceTypeId.TaxCategory, taxCategoryRef.TypeIdAsEnum);
        }
        
        [Fact]
        public void DeserializeShippingMethods()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            var serialized = File.ReadAllText("Resources/ShippingMethods/ShippingMethodsAsPageQueryResult.json");
            var shippingMethodsResult = serializerService.Deserialize<ShippingMethodPagedQueryResponse>(serialized);

            Assert.Equal(2, shippingMethodsResult.Count);
            Assert.Equal(20, shippingMethodsResult.Limit);
            Assert.Equal("7806c94b-bd59-47e0-b4b4-fd32ecd2f93d", shippingMethodsResult.Results[0].Id);
            Assert.Equal(ReferenceTypeId.TaxCategory, shippingMethodsResult.Results[0].TaxCategory.TypeIdAsEnum);
            Assert.Equal("3d018013-b53d-422a-933c-7294cf114323", shippingMethodsResult.Results[0].TaxCategory.Obj.Id);
        }
        
        [Fact]
        public void DeserializeKnowEnum()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            string serialized = @"
                {
                    ""type"": ""OrderState""
                }
            ";

            var state = serializerService.Deserialize<State>(serialized);

            Assert.Equal("OrderState", state.Type);
            Assert.Equal(StateTypeEnum.OrderState, state.TypeAsEnum);
        }
        
        [Fact]
        public void DeserializeUnKnowEnum()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            string serialized = @"
                {
                    ""type"": ""Unknown""
                }
            ";

            var state = serializerService.Deserialize<State>(serialized);

            Assert.Equal("Unknown", state.Type);
            var exception = Assert.Throws<ArgumentException>(() => state.TypeAsEnum);
        }
    }
}