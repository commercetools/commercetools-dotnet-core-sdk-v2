using System;
using System.Globalization;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StandalonePrices;
using Xunit;
using static commercetools.Api.IntegrationTests.Products.ProductsFixture;

namespace commercetools.Api.IntegrationTests.StandalonePricing
{
    [Collection("Integration Tests")]
    public class StandalonePricingTest
    {
        private readonly ProjectApiRoot _projectApiRoot;

        public StandalonePricingTest(ServiceProviderFixture serviceProviderFixture)
        {
            this._projectApiRoot = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task TimeSerialization()
        {
            await WithProduct(_projectApiRoot,
                draft => DefaultProductDraftWithMultipleVariants(draft, 2),
                async product =>
                {
                    var validFrom = DateTime.Parse("2022-02-02T00:00:00.000+02:00", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
                    var price = await _projectApiRoot.StandalonePrices().Post(new StandalonePriceDraft()
                    {
                        Sku = product.MasterData.Staged.MasterVariant.Sku,
                        Value = new CentPrecisionMoneyDraft()
                        {
                            CurrencyCode = "EUR",
                            CentAmount = 100
                        },
                        ValidFrom = validFrom
                    }).ExecuteAsync();

                    Assert.Equal(new DateTime(2022, 2, 1, 22, 0, 0, DateTimeKind.Utc), price.ValidFrom);


                }
            );
        }
    }
}