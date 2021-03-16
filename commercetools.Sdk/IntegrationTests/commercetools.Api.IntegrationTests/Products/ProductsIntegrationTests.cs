using System.IO;
using System.Linq;
using System.Threading.Tasks;
using commercetools.Api.Client;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Extensions;
using Xunit;
using static commercetools.Api.IntegrationTests.Products.ProductsFixture;

namespace commercetools.Api.IntegrationTests.Products
{
    [Collection("Integration Tests")]
    public class ProductsIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;
        
        public ProductsIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task UploadProductImage()
        {
            await WithProduct(_client,
                draft => DefaultProductDraftWithMultipleVariants(draft, 2),
                async product =>
                {

                    Assert.NotNull(product);
                    Assert.Equal(2, product.MasterData.Staged.Variants.Count);
                    Assert.Empty(product.MasterData.Staged.Variants[1].Images);
                    var variantId = product.MasterData.Staged.Variants[1].Id;
                    

                    var logoPath = @"Resources/ct_logo_farbe.gif";
                    var file = new FileStream(logoPath, FileMode.Open, FileAccess.Read);

                    var updateProduct = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Products()
                        .WithId(product.Id)
                        .Images()
                        .Post(file)
                        .WithFilename("logo.gif")
                        .WithVariant(variantId)
                        .WithStaged(true)
                        .AddHeader("content-type", "image/gif")
                        .ExecuteAsync();
                    
                    Assert.NotNull(updateProduct);
                    Assert.Single(updateProduct.MasterData.Staged.Variants[1].Images);
                    var img = updateProduct.MasterData.Staged.Variants[1].Images.FirstOrDefault();
                    Assert.NotNull(img);
                    Assert.Contains("logo", img.Url);
                });
        }
    }
}