using System;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Extensions;
using static commercetools.Sdk.Api.IntegrationTests.GenericFixture;

namespace commercetools.Sdk.Api.IntegrationTests.ProductTypes
{
    public class ProductTypesFixture
    {
        public static ProductTypeDraft DefaultProductTypeDraft(ProductTypeDraft productTypeDraft)
        {
            productTypeDraft.Key = TestingUtility.RandomString();
            productTypeDraft.Name = TestingUtility.RandomString();
            productTypeDraft.Description = TestingUtility.RandomString();
            return productTypeDraft;
        }

        #region CreateAndDelete

        public static async Task<IProductType> CreateProductType(IClient client, ProductTypeDraft productTypeDraft)
        {
            return await client.WithApi().WithProjectKey(DefaultProjectKey)
                .ProductTypes()
                .Post(productTypeDraft)
                .ExecuteAsync();
        }

        public static async Task DeleteProductType(IClient client, IProductType productType)
        {
            try
            {
                await client.WithApi().WithProjectKey(DefaultProjectKey)
                    .ProductTypes()
                    .WithId(productType.Id)
                    .Delete()
                    .WithVersion(productType.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static async Task<IProductType> CreateOrRetrieveProductType(IClient client, ProductTypeDraft productTypeDraft)
        {
            var projectKey = GenericFixture.DefaultProjectKey;
            IProductType productType = null;
            try
            {
                productType = await client.WithApi().WithProjectKey(projectKey)
                    .ProductTypes()
                    .WithKey(productTypeDraft.Key)
                    .Get()
                    .ExecuteAsync();
            }
            catch (NotFoundException)
            {
                productType = await client.WithApi()
                    .WithProjectKey(projectKey)
                    .ProductTypes()
                    .Post(productTypeDraft).ExecuteAsync();
            }

            return productType;
        }
        #endregion
        public static async Task WithProductType(IClient client, Func<IProductType, Task> func)
        {
            await WithAsync(client, new ProductTypeDraft(), DefaultProductTypeDraft, func, CreateProductType, DeleteProductType);
        }
    }
}