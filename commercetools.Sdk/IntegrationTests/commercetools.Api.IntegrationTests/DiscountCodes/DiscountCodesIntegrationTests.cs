// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// using System.Net;
// using System.Threading.Tasks;
// using commercetools.Base.Client;
// using commercetools.Base.Client.Error;
// using commercetools.Sdk.Api;
// using commercetools.Sdk.Api.Client;
// using commercetools.Sdk.Api.Extensions;
// using commercetools.Sdk.Api.Models.Common;
// using commercetools.Sdk.Api.Models.DiscountCodes;
// using commercetools.Sdk.Api.Serialization;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;
// using static commercetools.Api.IntegrationTests.GenericFixture;
// using Xunit;
//
// namespace commercetools.Api.IntegrationTests.DiscountCodes
// {
//     [Collection("Integration Tests")]
//     public class DiscountCodesIntegrationTests
//     {
//         private readonly IClient _client;
//         private readonly ProjectApiRoot _apiRoot;
//         private readonly ProjectApiRoot _projectApiRoot;
//
//         public DiscountCodesIntegrationTests(ServiceProviderFixture serviceProviderFixture)
//         {
//             this._client = serviceProviderFixture.GetService<IClient>();
//             this._apiRoot = serviceProviderFixture.GetService<ProjectApiRoot>();
//             this._projectApiRoot = serviceProviderFixture.GetService<ProjectApiRoot>();
//         }
//
//         [Fact]
//         public async Task createDiscountCodes()
//         {
//             var random = TestingUtility.RandomInt();
//             var discountCodesDraft = new DiscountCodeDraft
//             {
//                 Name = new LocalizedString { { "en", "Discount-Code" } },
//                 Code = random.ToString(),
//                 CartPredicate = "country=DE",
//                 IsActive = false
//             };
//
//             var resource = await _client.WithApi()
//                 .WithProjectKey(DefaultProjectKey)
//                 .DiscountCodes()
//                 .Post(discountCodesDraft)
//                 .ExecuteAsync();
//             
//             Assert.Single(resource.Id);
//             Assert.Single(resource.Code);
//             Assert.NotEmpty(resource.Name);
//         }
//     }
// }