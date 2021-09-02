using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.GraphQl;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Projects;
using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.States;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using commercetools.Base.Serialization;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using Xunit;
using JsonException = System.Text.Json.JsonException;

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
            var project = serializerService.Deserialize<IProject>(projectResponse);

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
            Assert.NotNull(taxCategoryRef.TypeId.Value);
            Assert.Equal(ReferenceTypeId.TaxCategory, taxCategoryRef.TypeId.Value);
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
            Assert.NotNull(shippingMethodsResult.Results[0].TaxCategory.TypeId.Value);
            Assert.Equal(ReferenceTypeId.TaxCategory, shippingMethodsResult.Results[0].TaxCategory.TypeId.Value);
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

            Assert.Equal(StateTypeEnum.OrderState, state.Type.Value);
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

            Assert.Equal("Unknown", state.Type.JsonName);
            Assert.Null(state.Type.Value);
        }

        [Fact]
        public void DeserializeOrder()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string orderSerialized = File.ReadAllText("Resources/Orders/order.json");

            var order = serializerService.Deserialize<Order>(orderSerialized);
            Assert.NotNull(order);
            Assert.NotNull(order.PaymentState.Value);
            Assert.Equal(PaymentState.Pending, order.PaymentState.Value);
            Assert.Null(order.ShipmentState);
        }

        [Fact]
        public void ReferenceDeserialization()
        {
            //Deserialize 2 of references to list of references with the correct instance type based on Type Id
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Types/References.json");
            var references = serializerService.Deserialize<List<IReference>>(serialized);
            Assert.IsType<CategoryReference>(references[0]);
            Assert.IsType<ProductReference>(references[1]);

            string serializedRev = File.ReadAllText("Resources/Types/Review.json");
            Review review = serializerService.Deserialize<Review>(serializedRev);
            Assert.IsType<JsonElement>(review.Target);
        }

        [Fact]
        public void DeserializeInvalidReference()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = @"{
                ""typeId"": ""unknown"",
                ""id"": ""123456""
            }";

            var reference = serializerService.Deserialize<IReference>(serialized);

            Assert.IsAssignableFrom<IReferenceTypeId>(reference.TypeId);
            Assert.Equal("unknown", reference.TypeId.JsonName);
        }


        [Fact]
        public void ResourceIdentifiersDeserialization()
        {
            //Deserialize 2 of resourceIdentifiers to list of resourceIdentifiers with the correct instance type based on Type Id
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = File.ReadAllText("Resources/Types/References.json");
            var resourceIdentifiers = serializerService.Deserialize<List<IResourceIdentifier>>(serialized);
            Assert.IsType<CategoryResourceIdentifier>(resourceIdentifiers[0]);
            Assert.IsType<ProductResourceIdentifier>(resourceIdentifiers[1]);
            string serializedRev = File.ReadAllText("Resources/Types/Review.json");
            Review review = serializerService.Deserialize<Review>(serializedRev);
            Assert.IsType<JsonElement>(review.Target);

        }

        [Fact]
        public void ProductDraftSerializationUsingResourceIdentifier()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            var productDraft = new ProductDraft
            {
                Name = new LocalizedString() { { "en", "name" } },
                Slug = new LocalizedString() { { "en", "slug" } },
                ProductType = new ProductTypeResourceIdentifier
                {
                    Key = "ProductTypeKey"
                },
                TaxCategory = new TaxCategoryResourceIdentifier
                {
                    Key = "TaxCategoryKey"
                },
                Categories = new List<ICategoryResourceIdentifier>()
                {
                    new CategoryResourceIdentifier()
                    {
                        Key = "CategoryKey"
                    }
                },
                State = new StateResourceIdentifier()
                {
                    Key = "StateKey"
                }
            };

            string result = serializerService.Serialize(productDraft);
            JToken resultFormatted = JValue.Parse(result);
            string serialized = File.ReadAllText("Resources/Types/ProductDraftWithResourceIdentifier.json");
            JToken serializedFormatted = JValue.Parse(serialized);
            serializedFormatted.Should().BeEquivalentTo(resultFormatted);
        }

        [Fact]
        public void ProductDraftSerializationUsingReference()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            var productDraft = new ProductDraft
            {
                Name = new LocalizedString()
                {
                    {"en", "name"},
                    {"en-US", "name"}
                },
                Slug = new LocalizedString() { { "en", "slug" } },
                ProductType = new ProductTypeResourceIdentifier()
                {
                    Id = "ProductTypeId"
                },
                TaxCategory = new TaxCategoryResourceIdentifier()
                {
                    Id = "TaxCategoryId"
                },
                Categories = new List<ICategoryResourceIdentifier>
                {
                    new CategoryResourceIdentifier()
                    {
                        Id = "CategoryId"
                    }
                },
                State = new StateResourceIdentifier
                {
                    Id = "StateId"
                }
            };

            string result = serializerService.Serialize(productDraft);
            JToken resultFormatted = JValue.Parse(result);
            string serialized = File.ReadAllText("Resources/Types/ProductDraftWithReference.json");
            JToken serializedFormatted = JValue.Parse(serialized);
            serializedFormatted.Should().BeEquivalentTo(resultFormatted);
        }

        [Fact]
        public void DeserializeCustomField()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            string serialized = @"
                {
                    ""fields"": {
                        ""foo"": ""bar"",
                        ""Foos"": ""Bars""
                    }
                }
            ";

            var customFields = serializerService.Deserialize<ICustomFields>(serialized);

            Assert.Equal("bar", customFields.Fields["foo"]);
            Assert.Equal("Bars", customFields.Fields["Foos"]);
        }


        [Fact]
        public void TestFacetResultsDeserialization()
        {
            //arrange
            var response = File.ReadAllText("Resources/ProductProjectionSearch/FacetResults.json");
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            //act
            var facetResults = serializerService.Deserialize<IFacetResults>(response);

            //assert
            Assert.NotNull(facetResults);
            Assert.Single(facetResults.Keys);
            Assert.IsAssignableFrom<ITermFacetResult>(facetResults["size"]);
            var sizeFacetResults = facetResults["size"] as TermFacetResult;
            Assert.NotNull(sizeFacetResults);
            Assert.Equal(5, sizeFacetResults.Terms.Count);
            var xxxlTerm = sizeFacetResults.Terms.FirstOrDefault();
            Assert.NotNull(xxxlTerm);
            Assert.Equal(1, xxxlTerm.Count);
            Assert.Equal("XXXL", xxxlTerm.Term.ToString());

        }

        [Fact]
        public void TestGraphQlResponseDeserialization()
        {
            //arrange
            var response = File.ReadAllText("Resources/GraphQL/response.json");
            var serializerService = this.serializationFixture.SerializerService;

            //act
            var result = serializerService.Deserialize<GraphQLResponse>(response);

            //assert
            var typedResult = ((JsonElement)result.Data).ToObject<GraphResultData>(serializerService);
            var customersResult = typedResult.Customers;
            Assert.NotNull(customersResult);
            Assert.Equal(customersResult.Count, customersResult.Results.Count);
        }

    }
}