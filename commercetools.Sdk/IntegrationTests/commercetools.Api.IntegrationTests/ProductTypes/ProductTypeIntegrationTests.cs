using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.ProductTypes;
using Xunit;

namespace commercetools.Api.IntegrationTests.ProductTypes
{
    [Collection("Integration Tests")]
    public class ProductTypeIntegrationTests
    {
        private readonly ProjectApiRoot _projectApiRoot;

        public ProductTypeIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._projectApiRoot = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task NestedProductType()
        {
            IProductType storeProductType;
            try
            {
                storeProductType = await _projectApiRoot.ProductTypes().WithKey("Store").Get().ExecuteAsync();
            }
            catch (NotFoundException)
            {
                var storeProductTypeDraft = new ProductTypeDraft()
                {
                    Key = "Store",
                    Name = "Store",
                    Description = "The description of Store",
                    Attributes = new List<IAttributeDefinitionDraft>()
                    {
                        new AttributeDefinitionDraft()
                        {
                            Name = "identifier",
                            Type = new AttributeTextType(),
                            Label = new LocalizedString() { { "en", "identifier" } },
                            IsRequired = false

                        },
                        new AttributeDefinitionDraft()
                        {
                            Name = "name",
                            Type = new AttributeSetType() { ElementType = new AttributeLocalizableTextType() },
                            Label = new LocalizedString() { { "en", "name" } },
                            IsRequired = false

                        },
                    }
                };
                storeProductType = _projectApiRoot
                    .ProductTypes()
                    .Post(storeProductTypeDraft)
                    .ExecuteAsync()
                    .Result;
            }

            IProductType bestsellerProductType;
            try
            {
                bestsellerProductType = await _projectApiRoot.ProductTypes().WithKey("BestSeller").Get().ExecuteAsync();
            }
            catch (NotFoundException)
            {
                var bestsellerProductTypeDraft = new ProductTypeDraft()
                {
                    Key = "BestSeller",
                    Name = "BestSeller",
                    Description = "The description of BestSeller",
                    Attributes = new List<IAttributeDefinitionDraft>()
                    {
                        new AttributeDefinitionDraft()
                        {
                            Name = "score",
                            Type =  new AttributeNumberType() ,
                            Label = new LocalizedString() { { "en", "score" } },
                            IsRequired = false

                        },
                        new AttributeDefinitionDraft()
                        {
                            Name = "stores",
                            Type = new AttributeSetType() { ElementType = new AttributeNestedType()
                            {
                                TypeReference = new ProductTypeReference() { Id = storeProductType.Id }
                            } },
                            Label = new LocalizedString() { { "en", "stores" } },
                            IsRequired = false
                        },
                    }
                };


                bestsellerProductType = _projectApiRoot
                    .ProductTypes()
                    .Post(bestsellerProductTypeDraft)
                    .ExecuteAsync()
                    .Result;
            }

            IProductType styleColourProductType;
            try
            {
                styleColourProductType = await _projectApiRoot.ProductTypes().WithKey("StyleColour").Get().ExecuteAsync();
            }
            catch (NotFoundException)
            {
                var styleColourProductTypeDraft = new ProductTypeDraft()
                {

                    Key = "StyleColour",
                    Name = "StyleColour",
                    Description = "The description of StyleColour",
                    Attributes = new List<IAttributeDefinitionDraft>()
                    {
                        new AttributeDefinitionDraft()
                            {
                                Name = "superCategories",
                                Type = new AttributeSetType() { ElementType = new AttributeTextType() },
                                Label = new LocalizedString() { { "en", "superCategories" } },
                                IsRequired = false

                            },
                        new AttributeDefinitionDraft()
                            {
                                Name = "approvalStatus",
                                Type = new AttributeTextType(),
                                IsRequired = false,
                                IsSearchable = true,
                                Label = new LocalizedString() { { "en", "approvalStatus" } }
                            },
                        new AttributeDefinitionDraft()
                            {
                                Name = "noFollowStatus",
                                Type = new AttributeTextType(),
                                IsRequired = false,
                                IsSearchable = true,
                                Label = new LocalizedString() { { "en", "noFollowStatus" } }
                            },
                        new AttributeDefinitionDraft()
                            {
                                Name = "noIndexStatus",
                                Type = new AttributeTextType(),
                                IsRequired = false,
                                IsSearchable = true,
                                Label = new LocalizedString() { { "en", "noIndexStatus" } }
                            },
                        new AttributeDefinitionDraft()
                            {
                                Name = "bestsellers",
                                Type = new AttributeSetType() { ElementType =  new AttributeNestedType() {  TypeReference = new ProductTypeReference() { Id = bestsellerProductType.Id }  } },
                                Label = new LocalizedString() { { "en", "bestsellers" } },
                            }
                    }
                };


                styleColourProductType = _projectApiRoot
                    .ProductTypes()
                    .Post(styleColourProductTypeDraft)
                    .ExecuteAsync()
                    .Result;
            }

            var random = TestingUtility.RandomString();
            var newProductDetails = new ProductDraft()
            {
                Key = $"17551191-{random}",
                Description = new LocalizedString
                {
                    { "en", "AX PRINTED SHIRT DRESS" },
                },
                Name = new LocalizedString
                {
                    { "en", $"AX PRINTED SHIRT DRESS-{random}" },
                },
                ProductType = new ProductTypeResourceIdentifier()
                {
                    Id = styleColourProductType.Id
                },
                Slug = new LocalizedString
                {
                    { "en", $"AX_PRINTED_SHIRT_DRESS-{random}" },
                },
                Publish = false,
                MasterVariant = new ProductVariantDraft
                {
                    Key = $"175511901-{random}",
                    Sku = $"175511901-{random}",
                    Attributes = new List<IAttribute>()
                    {
                        new SetAttribute<NestedAttribute>() {
                            Name = "bestsellers",
                            Value = new List<List<IAttribute>>()
                                {
                                    new List<IAttribute>() {
                                        new DecimalAttribute()
                                        {
                                            Name = "score",
                                            Value = 0.1d,
                                        },
                                        new SetAttribute<List<Attribute>>() {
                                            Name = "stores",
                                            Value = new List<List<IAttribute>>()
                                            {
                                                new List<IAttribute>()
                                                {
                                                    new StringAttribute()
                                                    {
                                                        Name = "identifier",
                                                        Value = "my-store-1"
                                                    },
                                                    new SetAttribute<LocalizedString>()
                                                    {
                                                        Name = "name",
                                                        Value = new List<LocalizedString>()
                                                        {
                                                            new LocalizedString() {{"en", "My store 1 in philly"}}
                                                        }
                                                    },
                                                }
                                            },
                                        }
                                    }
                                }
                        },
                    }
                }

            };

            var product = _projectApiRoot
                .Products()
                .Post(newProductDetails)
                .ExecuteAsync()
                .Result;

            Assert.Equal($"17551191-{random}", product.Key);

            await _projectApiRoot.Products().WithId(product.Id).Delete().WithVersion(product.Version).ExecuteAsync();
        }
    }
}