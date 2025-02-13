using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using commercetools.Base.Models;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StandalonePrices;
using commercetools.Sdk.Api.Predicates.Query.Types;
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

        [Fact]
        public void CustomFieldQuery()
        {
            var result = _projectApiRoot
                    .StandalonePrices()
                    .Get()
                    .WithSort("key asc")
                    .WithQuery(q => q.Custom(c => 
                        c.Fields(fields => 
                            fields.Field("productId").String().Is("abcdef")
                            .And(fields.Field("channelKey").String().Is("my-channel"))
                            .And(
                                fields.Field("validFrom").DateTime().IsLessThanOrEqual(Date.Parse("2025-02-11T00:00:00.000Z"))
                                .Or(fields.Field("validFrom").DateTime().IsNotDefined())
                                .Group()
                            ).And(
                                fields.Field("validUntil").DateTime().IsGreaterThanOrEqual(Date.Parse("2025-02-11T12:00:00.000Z"))
                                .Or(fields.Field("validUntil").DateTime().IsNotDefined())
                                .Group()
                            )
                        )
                    ));
                Assert.Equal("custom(fields(productId = \"abcdef\" and channelKey = \"my-channel\" and (validFrom <= \"2025-02-10T23:00:00Z\" or validFrom is not defined) and (validUntil >= \"2025-02-10T23:00:00Z\" or validUntil is not defined)))", result.GetQueryParams().First(pair => pair.Key == "where").Value);
        }
    }
}