using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.DiscountCodes;
using static commercetools.Api.IntegrationTests.CartDiscount.CartDiscountFixtures;
using static commercetools.Api.IntegrationTests.DiscountCodes.DiscountCodesFixtures;
using Xunit;

namespace commercetools.Api.IntegrationTests.DiscountCodes
{
    [Collection("Integration Tests")]
    public class DiscountCodesIntegrationTests
    {
        private readonly ProjectApiRoot _projectApiRoot;

        public DiscountCodesIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._projectApiRoot = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task CreateDiscountCodes()
        {
            // create CartDiscount code
            var key = $"CreateCartDiscount-{TestingUtility.RandomString()}";
            await WithCartDiscount(
                _projectApiRoot,
                cartDiscountDraft => DefaultCartDiscountDraftWithKey(cartDiscountDraft, key),
                async cartDiscount =>
                {
                    Assert.Equal(key, cartDiscount.Key);
                    // create DiscountCodes
                    await WithDiscountCodes(
                        _projectApiRoot,
                        discountCodesDraft =>
                        {
                            discountCodesDraft.Code = TestingUtility.RandomString();
                            discountCodesDraft.CartDiscounts = new List<ICartDiscountResourceIdentifier>()
                            {
                                new CartDiscountResourceIdentifier()
                                {
                                    TypeId = IReferenceTypeId.CartDiscount,
                                    Id = cartDiscount.Id
                                }
                            };
                            return DefaultDiscountCodesDraft(discountCodesDraft);
                        },
                        discountCode =>
                        {
                            var codes = discountCode.Code;
                            Assert.NotNull(discountCode);
                            Assert.Equal(codes, discountCode.Code);
                        }
                    );
                }
            );
        }

        [Fact]
        public async Task GetDiscountCodeById()
        {
            // create CartDiscount code
            var key = $"CreateCartDiscount-{TestingUtility.RandomString()}";
            var keys = $"CreateCartDiscount-{TestingUtility.RandomString()}";

            await WithCartDiscount(
                _projectApiRoot,
                cartDiscountDraft => DefaultCartDiscountDraftWithKey(cartDiscountDraft, key),
                async cartDiscount =>
                {
                    Assert.Equal(key, cartDiscount.Key);
                    // create DiscountCodes
                    await WithDiscountCodes(
                        _projectApiRoot,
                        discountCodesDraft =>
                        {
                            discountCodesDraft.Code = TestingUtility.RandomString();
                            discountCodesDraft.CartDiscounts = new List<ICartDiscountResourceIdentifier>()
                            {
                                new CartDiscountResourceIdentifier()
                                {
                                    TypeId = IReferenceTypeId.CartDiscount,
                                    Id = cartDiscount.Id
                                }
                            };
                            return DefaultDiscountCodeDraftWithKey(discountCodesDraft, keys);
                        },
                        async discountCode =>
                        {
                            Assert.NotNull(discountCode);
                            var retrievedDiscountCode = await _projectApiRoot
                                .DiscountCodes()
                                .WithId(discountCode.Id)
                                .Get()
                                .ExecuteAsync();

                            Assert.NotNull(retrievedDiscountCode);
                            Assert.Equal(keys, retrievedDiscountCode.Key);
                        }
                    );
                }
            );
        }

        [Fact]
        public async Task QueryDiscountCodeById()
        {
            // create CartDiscount code
            var key = $"CreateCartDiscount-{TestingUtility.RandomString()}";
            var keys = $"CreateCartDiscount-{TestingUtility.RandomString()}";

            await WithCartDiscount(
                _projectApiRoot,
                cartDiscountDraft => DefaultCartDiscountDraftWithKey(cartDiscountDraft, key),
                async cartDiscount =>
                {
                    Assert.Equal(key, cartDiscount.Key);
                    // create DiscountCodes
                    await WithDiscountCodes(
                        _projectApiRoot,
                        discountCodesDraft =>
                        {
                            discountCodesDraft.Code = TestingUtility.RandomString();
                            discountCodesDraft.CartDiscounts = new List<ICartDiscountResourceIdentifier>()
                            {
                                new CartDiscountResourceIdentifier()
                                {
                                    TypeId = IReferenceTypeId.CartDiscount,
                                    Id = cartDiscount.Id
                                }
                            };
                            return DefaultDiscountCodeDraftWithKey(discountCodesDraft, keys);
                        },
                        async discountCode =>
                        {
                            Assert.NotNull(discountCode);
                            var retrievedDiscountCode = await _projectApiRoot
                                .DiscountCodes()
                                .Get()
                                .WithQuery(d => d.Id().Is(discountCode.Id))
                                .ExecuteAsync();

                            Assert.NotNull(retrievedDiscountCode);
                        }
                    );
                }
            );
        }

        [Fact]
        public async Task UpdateDiscountCodeByIdSetKey()
        {
            // create CartDiscount code
            var key = $"Create-CartDiscount-{TestingUtility.RandomString()}";
            var discountCodeDraftKeys = $"Create-DiscountCode-{TestingUtility.RandomString()}";

            await WithCartDiscount(
                _projectApiRoot,
                cartDiscountDraft => DefaultCartDiscountDraftWithKey(cartDiscountDraft, key),
                async cartDiscount =>
                {
                    Assert.Equal(key, cartDiscount.Key);
                    // update DiscountCodes
                    await WithUpdateableDiscountCodes(
                        _projectApiRoot,
                        discountCodesDraft =>
                        {
                            discountCodesDraft.Code = TestingUtility.RandomString();
                            discountCodesDraft.CartDiscounts = new List<ICartDiscountResourceIdentifier>()
                            {
                                new CartDiscountResourceIdentifier()
                                {
                                    TypeId = IReferenceTypeId.CartDiscount,
                                    Id = cartDiscount.Id
                                }
                            };
                            return DefaultDiscountCodeDraftWithKey(discountCodesDraft, discountCodeDraftKeys);
                        },
                        async discountCode =>
                        {
                            Assert.NotNull(discountCode);
                            var discountCodeKey = $"Test-DiscountCodeKey-{TestingUtility.RandomString()}";

                            var action = new DiscountCodeSetKeyAction()
                            {
                                Action = "setKey",
                                Key = discountCodeKey
                            };

                            var update = new DiscountCodeUpdate()
                            {
                                Version = discountCode.Version,
                                Actions = new List<IDiscountCodeUpdateAction>() { action }
                            };

                            var updatedDiscountCode = await _projectApiRoot
                                .DiscountCodes()
                                .WithId(discountCode.Id)
                                .Post(update)
                                .ExecuteAsync();

                            Assert.NotNull(updatedDiscountCode);
                            Assert.Equal(discountCodeKey, updatedDiscountCode.Key);

                            return updatedDiscountCode;
                        }
                    );
                }
            );
        }
    }
}