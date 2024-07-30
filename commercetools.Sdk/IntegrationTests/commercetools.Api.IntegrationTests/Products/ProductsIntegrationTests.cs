using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Serialization;
using commercetools.Sdk.GraphQL.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using static commercetools.Api.IntegrationTests.Products.ProductsFixture;
using ProductDraft = commercetools.Sdk.Api.Models.Products.ProductDraft;

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
        public async Task HeadRequest()
        {
            await WithProduct(_projectApiRoot, async product =>
            {
                var execute = await _projectApiRoot.Products().WithKey(product.Key).Head().ExecuteAsync();
                Assert.Equal("", execute);
                var send = await _projectApiRoot.Products().WithKey(product.Key).Head().SendAsync();
                Assert.Equal(HttpStatusCode.OK, send.StatusCode);

                await Assert.ThrowsAsync<NotFoundException>(async () =>
                {
                    await _projectApiRoot.Products().WithKey(product.Key + "-unknown").Head()
                        .ExecuteAsync();
                });
                await Assert.ThrowsAsync<NotFoundException>(async () =>
                {
                    await _projectApiRoot.Products().WithKey(product.Key + "-unknown").Head().SendAsync();
                });
            });
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
                        .AddHeader(ApiHttpHeaders.CONTENT_TYPE, "image/gif")
                        .ExecuteAsync();

                    Assert.NotNull(updateProduct);
                    Assert.Single(updateProduct.MasterData.Staged.Variants[1].Images);
                    var img = updateProduct.MasterData.Staged.Variants[1].Images.FirstOrDefault();
                    Assert.NotNull(img);
                    Assert.Contains("logo", img.Url);

                    var logoPngPath = @"Resources/ct-logo.png";
                    var filePng = new FileStream(logoPngPath, FileMode.Open, FileAccess.Read);

                    var updateProductPng = await _projectApiRoot
                        .Products()
                        .WithId(product.Id)
                        .Images()
                        .Post(filePng)
                        .WithVariant(variantId)
                        .WithStaged(true)
                        .AddHeader(ApiHttpHeaders.CONTENT_TYPE, "image/png")
                        .ExecuteAsync();
                    Assert.NotNull(updateProductPng);
                    var imgPng = updateProductPng.MasterData.Staged.Variants[1].Images.FirstOrDefault(image => image.Url.EndsWith("png"));
                    Assert.NotNull(imgPng);
                    Assert.Contains("img", imgPng.Url);
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

        [Fact]
        public async Task Unpublish()
        {
            await WithUpdateableProduct(_projectApiRoot, async product =>
            {
                var updatedProduct = await _projectApiRoot.Products().WithId(product.Id).Post(new ProductUpdate()
                {
                    Version = product.Version,
                    Actions = new List<IProductUpdateAction>()
                    {
                        new ProductUnpublishAction()
                    }
                }).ExecuteAsync();

                Assert.False(updatedProduct.MasterData.Published);
                return updatedProduct;
            });
        }

        [Fact]
        public async Task DeserializeProductAttributeWithGraphQL()
        {
            await WithProduct(_projectApiRoot,
                draft =>
                {
                    var d = DefaultProductDraftWithMultipleVariants(draft, 5);
                    return d;
                },
                async product =>
                {
                    var key = product.Key;
                    var response = await _projectApiRoot.GraphQLClient().Query(o =>
                    o.Product(
                        key: key,
                        // queryFilters: t,
                        selector: product => new
                        {
                            MasterData = product.MasterData(data => new
                            {
                                Staged = data.Staged(staged => new
                                {
                                    Variants = staged.Variants(selector: variant => new
                                    {
                                        Attributes = variant.AttributesRaw(selector: attribute => new
                                        {
                                            Name = attribute.Name,
                                            Value = attribute.Value
                                        })
                                    })
                                })
                            })
                        }
                    )
                );
                    Assert.NotNull(response);

                    Assert.Equal("number", response.Data.MasterData.Staged.Variants[0].Attributes[0].Name);
                    Assert.IsType<decimal>(response.Data.MasterData.Staged.Variants[0].Attributes[0].Value.GetValue<decimal>());
                    Assert.Equal("integer", response.Data.MasterData.Staged.Variants[0].Attributes[1].Name);
                    Assert.IsType<int>(response.Data.MasterData.Staged.Variants[0].Attributes[1].Value.GetValue<int>());
                    Assert.Equal("text", response.Data.MasterData.Staged.Variants[0].Attributes[2].Name);
                    Assert.IsType<string>(response.Data.MasterData.Staged.Variants[0].Attributes[2].Value.GetValue<string>());
                    Assert.Equal("enum", response.Data.MasterData.Staged.Variants[0].Attributes[3].Name);
                    Assert.IsType<PlainEnumValue>(response.Data.MasterData.Staged.Variants[0].Attributes[3].Value.Deserialize<PlainEnumValue>());
                    Assert.Equal("foo", response.Data.MasterData.Staged.Variants[0].Attributes[3].Value.Deserialize<PlainEnumValue>().Key);
                    Assert.Equal("foo", response.Data.MasterData.Staged.Variants[0].Attributes[3].Value.Deserialize<PlainEnumValue>().Label);
                });
        }
    }
}