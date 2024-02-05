using System;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Models.Reviews;
using static commercetools.Api.IntegrationTests.GenericFixture;
using commercetools.Sdk.Api.Extensions;

namespace commercetools.Api.IntegrationTests.Review
{
    public class ReviewFixtures
    {
        #region DraftBuilds

        public static ReviewDraft DefaultReviewDraft(ReviewDraft reviewDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            var randomStr = TestingUtility.RandomString();

            reviewDraft.Key = $"Test-Key-{randomInt}";
            reviewDraft.Title = $"Test-Title-{randomStr}";

            return reviewDraft;
        }

        #endregion

        public static ReviewDraft DefaultReviewDraftWithKey(ReviewDraft draft, string key)
        {
            var reviewDraft = DefaultReviewDraft(draft);
            reviewDraft.Key = key;

            return reviewDraft;
        }

        public static async Task<IReview> CreateReview(IClient client,
            ReviewDraft reviewDraft)
        {
            try
            {
                return await client
                    .WithApi()
                    .WithProjectKey(DefaultProjectKey)
                    .Reviews()
                    .Post(reviewDraft)
                    .ExecuteAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteReview(IClient client, IReview review)
        {
            try
            {
                await client
                    .WithApi()
                    .WithProjectKey(DefaultProjectKey)
                    .Reviews()
                    .WithId(review.Id)
                    .Delete()
                    .WithVersion(review.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region

        public static async Task WithReview(IClient client,
            Func<ReviewDraft, ReviewDraft> draftAction,
            Action<IReview> func)
        {
            await With(client, new ReviewDraft(), draftAction, func, CreateReview,
                DeleteReview);
        }

        public static async Task WithReview(IClient client,
            Func<ReviewDraft, ReviewDraft> draftAction,
            Func<IReview, Task> func)
        {
            await WithAsync(client, new ReviewDraft(), draftAction, func, CreateReview,
                DeleteReview);
        }

        public static async Task WithUpdateableReview(IClient client,
            Func<IReview, Task<IReview>> func)
        {
            await WithUpdateableAsync(client, new ReviewDraft(), DefaultReviewDraft, func,
                CreateReview,
                DeleteReview);
        }

        #endregion
    }
}