using System;
using System.Threading.Tasks;
using commercetools.Api.Client;
using commercetools.Api.Models.ProductTypes;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.ProductTypes
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

        public static async Task<ProductType> CreateProductType(IClient client, ProductTypeDraft productTypeDraft)
        {
            return await client.ApiRoot().WithProjectKey(DefaultProjectKey)
                .ProductTypes()
                .Post(productTypeDraft)
                .ExecuteAsync();
        }
        
        public static async Task DeleteProductType(IClient client, ProductType productType)
        {
            try
            {
                await client.ApiRoot().WithProjectKey(DefaultProjectKey)
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
        
        public static async Task<ProductType> CreateOrRetrieveProductType(IClient client, ProductTypeDraft productTypeDraft)
        {
            var projectKey = GenericFixture.DefaultProjectKey;
            ProductType productType = null;
            try
            {
                productType = await client.ApiRoot().WithProjectKey(projectKey)
                    .ProductTypes()
                    .WithKey(productTypeDraft.Key)
                    .Get()
                    .ExecuteAsync();
            }
            catch (NotFoundException)
            {
                productType = await client.ApiRoot()
                    .WithProjectKey(projectKey)
                    .ProductTypes()
                    .Post(productTypeDraft).ExecuteAsync();   
            }

            return productType;
        }
        #endregion
        public static async Task WithProductType( IClient client, Func<ProductType, Task> func)
        {
            await WithAsync(client, new ProductTypeDraft(), DefaultProductTypeDraft, func, CreateProductType, DeleteProductType);
        }
    }
}