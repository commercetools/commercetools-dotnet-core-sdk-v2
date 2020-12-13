using System;
using System.Threading.Tasks;
using commercetools.Api.Client;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.ProductTypes;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;

namespace commercetools.Api.IntegrationTests.Products
{
    public class ProductTypesFixture
    {
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
    }
}