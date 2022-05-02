using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using static commercetools.Api.IntegrationTests.GenericFixture;
using static commercetools.Api.IntegrationTests.ProductTypes.ProductTypesFixture;

namespace commercetools.Api.IntegrationTests.Products
{
    public class ProductsFixture
    {
        #region DraftBuilds
        public static ProductDraft DefaultProductDraft(ProductDraft productDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            productDraft.Name = new LocalizedString
            {
                {"en", $"Name_{randomInt}"},
                {"de", $"Name_de_{randomInt}"}
            };
            productDraft.Slug = new LocalizedString
            {
                {"en", $"Slug_{randomInt}"},
                {"de", $"Slug_de_{randomInt}"}
            };
            productDraft.Key = $"Key_{randomInt}";
            productDraft.Publish = true;
            productDraft.MasterVariant = new ProductVariantDraft
            {
                Key = $"variant0_Key_{randomInt}",
                Sku = $"variant0_Sku_{randomInt}",
                Attributes = new List<IAttribute>()
                {
                    new DecimalAttribute() { Name = "number", Value = TestingUtility.RandomDecimal()},
                    new LongAttribute() { Name = "integer", Value = TestingUtility.RandomInt()},
                    new StringAttribute() { Name = "text", Value = $"Attribute_{randomInt}"},
                }
            };
            return productDraft;
        }
        public static ProductDraft DefaultProductDraftWithMultipleVariants(ProductDraft draft, int variantsCount = 1)
        {
            var randomInt = TestingUtility.RandomInt();
            var productDraft = DefaultProductDraft(draft);

            if (variantsCount > 0)
            {
                var variants = new List<IProductVariantDraft>();
                for (var i = 1; i <= variantsCount; i++)
                {
                    var productVariant = new ProductVariantDraft
                    {
                        Key = $"variant{i}_Key_{randomInt}",
                        Sku = $"variant{i}_Sku_{randomInt}",
                        Attributes = new List<IAttribute>()
                        {
                            new DecimalAttribute() { Name = "number", Value = TestingUtility.RandomDecimal() },
                            new LongAttribute() { Name = "integer", Value = TestingUtility.RandomInt() },
                            new StringAttribute() { Name = "text", Value = $"Attribute_{randomInt}" },
                        }
                    };
                    variants.Add(productVariant);
                }

                productDraft.Variants = variants;
            }

            return productDraft;
        }

        #endregion

        #region CreateAndDelete

        public static async Task<IProduct> CreateProduct(ProjectApiRoot apiRoot, ProductDraft productDraft)
        {
            var resource = await apiRoot
                .Products()
                .Post(productDraft)
                .ExecuteAsync();
            return resource;
        }

        public static async Task<IProduct> CreateProduct(IClient client, ProductDraft productDraft)
        {
            return await CreateProduct(client.WithProject(DefaultProjectKey), productDraft);
        }

        public static async Task DeleteProduct(IClient client, IProduct product)
        {
            await DeleteProduct(client.WithProject(DefaultProjectKey), product);
        }

        public static async Task DeleteProduct(ProjectApiRoot apiRoot, IProduct product)
        {
            try
            {
                var version = product.Version;
                if (product.MasterData.Published)
                {
                    var updatedProduct = await apiRoot
                         .Products()
                         .WithId(product.Id)
                         .Post(new ProductUpdate
                         {
                             Actions = new List<IProductUpdateAction>
                             {
                                new ProductUnpublishAction()
                             }
                         })
                         .ExecuteAsync();
                    version = updatedProduct.Version;
                }
                await apiRoot
                    .Products()
                    .WithId(product.Id)
                    .Delete()
                    .WithVersion(version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static async Task<IProduct> CreateOrRetrieveProduct(IClient client, ProductDraft productDraft)
        {
            return await CreateOrRetrieveProduct(client.WithProject(DefaultProjectKey), productDraft);
        }
        public static async Task<IProduct> CreateOrRetrieveProduct(ProjectApiRoot apiRoot, ProductDraft productDraft)
        {
            IProduct product = null;
            try
            {
                product = await apiRoot
                    .Products()
                    .WithKey(productDraft.Key)
                    .Get()
                    .ExecuteAsync();
            }
            catch (NotFoundException)
            {
                product = await apiRoot
                    .Products()
                    .Post(productDraft).ExecuteAsync();
            }

            return product;
        }
        #endregion

        public static async Task WithProduct(IClient client, Func<IProduct, Task> func)
        {
            await WithProduct(client.WithProject(DefaultProjectKey), func);
        }

        public static async Task WithProduct(ProjectApiRoot apiRoot, Func<IProduct, Task> func)
        {
            await WithProductType(apiRoot, async productType =>
            {
                var productDraftWithProductType = new ProductDraft
                {
                    ProductType = new ProductTypeResourceIdentifier { Key = productType.Key }
                };
                await WithAsync(apiRoot, productDraftWithProductType,
                    DefaultProductDraft, func, CreateProduct, DeleteProduct);
            });
        }

        public static async Task WithProduct(IClient client, Func<ProductDraft, ProductDraft> draftAction,
            Func<IProduct, Task> func)
        {
            await WithProduct(client.WithProject(DefaultProjectKey), draftAction, func);
        }

        public static async Task WithProduct(ProjectApiRoot apiRoot, Func<ProductDraft, ProductDraft> draftAction, Func<IProduct, Task> func)
        {
            await WithProductType(apiRoot, async productType =>
            {
                var productDraftWithProductType = new ProductDraft
                {
                    ProductType = new ProductTypeResourceIdentifier { Key = productType.Key }
                };

                await WithAsync(apiRoot, productDraftWithProductType, draftAction, func, CreateProduct, DeleteProduct);
            });
        }

    }
}