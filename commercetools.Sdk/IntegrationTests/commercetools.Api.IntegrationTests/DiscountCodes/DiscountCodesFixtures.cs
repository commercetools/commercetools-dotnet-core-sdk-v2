// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// using commercetools.Sdk.Api.Models.Common;
// using commercetools.Sdk.Api.Models.DiscountCodes;
// using commercetools.Base.Client;
// using commercetools.Sdk.Api.Extensions;
// using static commercetools.Api.IntegrationTests.GenericFixture;
//
// namespace commercetools.Api.IntegrationTests.DiscountCodes
// {
//     public class DiscountCodesFixtures
//     {
//         #region DraftBuilds
//         public static DiscountCodeDraft DefaultDiscountCodesDraft()
//         {
//             var random = TestingUtility.RandomInt();
//             var discountCodesDraft = new DiscountCodeDraft
//             {
//                 Name = new LocalizedString {{"en", "Name"}},
//                 Code = random.ToString(),
//                 CartPredicate = "country=DE",
//                 IsActive = false
//             };
//             
//             return discountCodesDraft;
//         }
//         #endregion
//
//         #region CreateAndDelete
//         
//         public static async Task<IDiscountCode> CreateDiscountCodes(IClient client, DiscountCodeDraft discountCodeDraft)
//         {
//             var resource = await client.WithApi().WithProjectKey(DefaultProjectKey)
//                 .DiscountCodes()
//                 .Post(discountCodeDraft)
//                 .ExecuteAsync();
//             return resource;
//         }
//         
//         public static async Task DeleteDiscountCode(IClient client, IDiscountCode discountCode)
//         {
//             try
//             {
//                 await client.WithApi().WithProjectKey(DefaultProjectKey)
//                     .DiscountCodes()
//                     .WithId(discountCode.Id)
//                     .Delete()
//                     .WithVersion(discountCode.Version)
//                     .ExecuteAsync();
//             }
//             catch (Exception)
//             {
//                 // ignored
//             }
//         }
//
//         #endregion
//         
//         #region WithDiscountCodes
//         
//         public static async Task WithDiscountCode(IClient client, Func<DiscountCodeDraft, DiscountCodeDraft> draftAction, Action<IDiscountCode> func)
//         {
//             await With(client, new DiscountCodeDraft(), draftAction, func, CreateDiscountCodes, DeleteDiscountCode);
//         }
//         #endregion
//     }
// }