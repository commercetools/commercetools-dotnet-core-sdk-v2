using System.IO;
using System.Linq;
using System.Threading.Tasks;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using static commercetools.Api.IntegrationTests.Products.ProductsFixture;

namespace commercetools.Api.IntegrationTests.Products
{
    [Collection("Integration Tests")]
    public class ProductsIntegrationTests
    {
        private readonly ProjectApiRoot _projectApiRoot;

        public ProductsIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._projectApiRoot = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task UploadProductImage()
        {
            await WithProduct(_projectApiRoot,
                draft => DefaultProductDraftWithMultipleVariants(draft, 2),
                async product =>
                {

                    Assert.NotNull(product);
                    Assert.Equal(2, product.MasterData.Staged.Variants.Count);
                    Assert.Empty(product.MasterData.Staged.Variants[1].Images);
                    var variantId = product.MasterData.Staged.Variants[1].Id;


                    var logoPath = @"Resources/ct_logo_farbe.gif";
                    var file = new FileStream(logoPath, FileMode.Open, FileAccess.Read);

                    var updateProduct = await _projectApiRoot
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

        [Fact]
        public async Task DeserializeNumberAttribute()
        {
            await WithProduct(_projectApiRoot,
                draft => DefaultProductDraftWithMultipleVariants((ProductDraft)draft, 2),
                product =>
                {
                    Assert.IsType<DecimalAttribute>(product.MasterData.Staged.MasterVariant.Attributes.Get("number"));
                    Assert.IsType<LongAttribute>(product.MasterData.Staged.MasterVariant.Attributes.Get("integer"));
                    Assert.IsType<decimal>(product.MasterData.Staged.MasterVariant.Attributes.Get("number").Value);
                    Assert.IsType<long>(product.MasterData.Staged.MasterVariant.Attributes.Get("integer").Value);
                    return Task.CompletedTask;
                });
        }


        [Fact]
        public async Task DeserializeNumberAttributeNumberOnly()
        {
            var services = new ServiceCollection();

            //services.AddLogging(configure => configure.AddConsole());
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.test.Development.json", true).
                AddEnvironmentVariables().
                AddUserSecrets<ServiceProviderFixture>().
                AddEnvironmentVariables("CTP_").
                Build();

            services.UseCommercetoolsApi(configuration, "Client", serializationConfiguration: new SerializationConfiguration() { DeserializeNumberAttributeAsDecimalOnly = true });
            var serviceProvider = services.BuildServiceProvider();
            var projectApiRoot = serviceProvider.GetService<ProjectApiRoot>();


            await WithProduct(projectApiRoot,
                draft => DefaultProductDraftWithMultipleVariants((ProductDraft)draft, 2),
                product =>
                {
                    Assert.IsType<DecimalAttribute>(product.MasterData.Staged.MasterVariant.Attributes.Get("number")
                       .ToDecimalAttribute());
                    Assert.IsType<DecimalAttribute>(product.MasterData.Staged.MasterVariant.Attributes.Get("integer"));
                    Assert.IsType<decimal>(product.MasterData.Staged.MasterVariant.Attributes.Get("number").Value);
                    Assert.IsType<decimal>(product.MasterData.Staged.MasterVariant.Attributes.Get("integer").Value);
                    return Task.CompletedTask;
                });
        }
    }
}