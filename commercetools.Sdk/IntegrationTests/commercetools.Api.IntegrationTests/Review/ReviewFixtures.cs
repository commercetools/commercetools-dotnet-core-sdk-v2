using System;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;
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

        public static async Task<IReview> CreateReview(ProjectApiRoot client,
            ReviewDraft reviewDraft)
        {
            try
            {
                return await client
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

        public static async Task DeleteReview(ProjectApiRoot client, IReview review)
        {
            try
            {
                await client
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

        public static async Task WithReview(ProjectApiRoot client,
            Func<ReviewDraft, ReviewDraft> draftAction,
            Action<IReview> func)
        {
            await With(client, new ReviewDraft(), draftAction, func, CreateReview,
                DeleteReview);
        }

        public static async Task WithReview(ProjectApiRoot client,
            Func<ReviewDraft, ReviewDraft> draftAction,
            Func<IReview, Task> func)
        {
            await WithAsync(client, new ReviewDraft(), draftAction, func, CreateReview,
                DeleteReview);
        }

        public static async Task WithUpdateableReview(ProjectApiRoot client,
            Func<IReview, Task<IReview>> func)
        {
            await WithUpdateableAsync(client, new ReviewDraft(), DefaultReviewDraft, func,
                CreateReview,
                DeleteReview);
        }

        #endregion
    }
}