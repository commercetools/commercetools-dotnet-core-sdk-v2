// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// using commercetools.Sdk.Api.Models.Common;
// using commercetools.Sdk.Api.Models.DiscountCodes;
// using commercetools.Base.Client;
// using commercetools.Sdk.Api.Extensions;
// using commercetools.Sdk.Api.Models.CartDiscounts;
// using static commercetools.Api.IntegrationTests.GenericFixture;
//
// namespace commercetools.Api.IntegrationTests.DiscountCodes
// {
//     public class DiscountCodesFixtures
//     {
//         #region DraftBuilds
//
//         public static DiscountCodeDraft DefaultDiscountCodesDraft(DiscountCodeDraft discountCodeDraft)
//         {
//             var randomInt = TestingUtility.RandomInt();
//             discountCodeDraft.Name = new LocalizedString { { "en", "Name" } };
//             discountCodeDraft.Code = randomInt.ToString();
//             discountCodeDraft.CartDiscounts = new List<ICartDiscountResourceIdentifier>()
//             {
//                 
//             };
//             discountCodeDraft.CartPredicate = "country=DE";
//             discountCodeDraft.IsActive = false;
//
//             return discountCodeDraft;
//         }
//
//         #endregion
//
//         #region CreateAndDelete
//
//         public static async Task<IDiscountCode> CreateDiscountCodes(IClient client, DiscountCodeDraft discountCodeDraft)
//         {
//             var resource = await client
//                 .WithApi()
//                 .WithProjectKey(DefaultProjectKey)
//                 .DiscountCodes()
//                 .Post(discountCodeDraft)
//                 .ExecuteAsync();
//
//             return resource;
//         }
//
//         public static async Task DeleteDiscountCodes(IClient client, IDiscountCode discountCode)
//         {
//             try
//             {
//                 await client
//                     .WithApi()
//                     .WithProjectKey(DefaultProjectKey)
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
//         public static async Task WithDiscountCodes(IClient client,
//             Func<DiscountCodeDraft, DiscountCodeDraft> draftAction, Action<IDiscountCode> func)
//         {
//             await With(client, new DiscountCodeDraft(), draftAction, func, CreateDiscountCodes, DeleteDiscountCodes);
//         }
//
//         public static async Task WithDiscountCodes(IClient client,
//             Func<DiscountCodeDraft, DiscountCodeDraft> draftAction,
//             Func<IDiscountCode, Task> func)
//         {
//             await WithAsync(client, new DiscountCodeDraft(), draftAction, func, CreateDiscountCodes,
//                 DeleteDiscountCodes);
//         }
//
//         public static async Task WithDiscountCodes(IClient client, Func<IDiscountCode, Task> func)
//         {
//             await WithAsync(client, new DiscountCodeDraft(), DefaultDiscountCodesDraft, func, CreateDiscountCodes,
//                 DeleteDiscountCodes);
//         }
//
//         public static async Task WithUpdateableDiscountCodes(IClient client,
//             Func<IDiscountCode, Task<IDiscountCode>> func)
//         {
//             await WithUpdateableAsync(client, new DiscountCodeDraft(), DefaultDiscountCodesDraft, func,
//                 CreateDiscountCodes,
//                 DeleteDiscountCodes);
//         }
//
//         #endregion
//     }
// }