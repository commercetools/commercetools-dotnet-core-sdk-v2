using System;
using System.Threading.Tasks;
using commercetools.Api.Client;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;

namespace commercetools.Api.IntegrationTests.Products
{
    public class ProductsFixture
    {
        public static async Task<Product> CreateOrRetrieveProduct(IClient client, ProductDraft productDraft)
        {
            var projectKey = GenericFixture.DefaultProjectKey;
            Product product = null;
            try
            {
                product = await client.ApiRoot().WithProjectKey(projectKey)
                    .Products()
                    .WithKey(productDraft.Key)
                    .Get()
                    .ExecuteAsync();
            }
            catch (NotFoundException)
            {
                product = await client.ApiRoot()
                    .WithProjectKey(projectKey)
                    .Products()
                    .Post(productDraft).ExecuteAsync();   
            }

            return product;
        }
    }
}