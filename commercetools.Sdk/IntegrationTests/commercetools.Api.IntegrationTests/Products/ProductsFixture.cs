using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.ProductTypes;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
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

            return productDraft;
        }
        public static ProductDraft DefaultProductDraftWithMultipleVariants(ProductDraft draft, int variantsCount = 1)
        {
            var randomInt = TestingUtility.RandomInt();
            var productDraft = DefaultProductDraft(draft);

            var variants = new List<IProductVariantDraft>();
            for (var i = 1; i <= variantsCount; i++)
            {
                var productVariant = new ProductVariantDraft
                {
                    Key = $"variant{i}_Key_{randomInt}",
                    Sku = $"variant{i}_Sku_{randomInt}"
                };
                variants.Add(productVariant);
            }

            productDraft.Variants = variants;
            return productDraft;
        }

        #endregion

        #region CreateAndDelete

        public static async Task<IProduct> CreateProduct(IClient client, ProductDraft productDraft)
        {
            var resource = await client.WithApi().WithProjectKey(DefaultProjectKey)
                .Products()
                .Post(productDraft)
                .ExecuteAsync();
            return resource;
        }

        public static async Task DeleteProduct(IClient client, IProduct product)
        {
            try
            {
                var version = product.Version;
                if (product.MasterData.Published)
                {
                    var updatedProduct = await client.WithApi().WithProjectKey(DefaultProjectKey)
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
                await client.WithApi().WithProjectKey(DefaultProjectKey)
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
            var projectKey = GenericFixture.DefaultProjectKey;
            IProduct product = null;
            try
            {
                product = await client.WithApi().WithProjectKey(projectKey)
                    .Products()
                    .WithKey(productDraft.Key)
                    .Get()
                    .ExecuteAsync();
            }
            catch (NotFoundException)
            {
                product = await client.WithApi()
                    .WithProjectKey(projectKey)
                    .Products()
                    .Post(productDraft).ExecuteAsync();
            }

            return product;
        }
        #endregion

        public static async Task WithProduct(IClient client, Func<IProduct, Task> func)
        {
            await WithProductType(client, async productType =>
            {
                var productDraftWithProductType = new ProductDraft
                {
                    ProductType = new ProductTypeResourceIdentifier { Key = productType.Key }
                };
                await WithAsync(client, productDraftWithProductType,
                    DefaultProductDraft, func, CreateProduct, DeleteProduct);
            });
        }
        public static async Task WithProduct(IClient client, Func<ProductDraft, ProductDraft> draftAction, Func<IProduct, Task> func)
        {
            await WithProductType(client, async productType =>
            {
                var productDraftWithProductType = new ProductDraft
                {
                    ProductType = new ProductTypeResourceIdentifier { Key = productType.Key }
                };

                await WithAsync(client, productDraftWithProductType, draftAction, func, CreateProduct, DeleteProduct);
            });
        }

    }
}