using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Models.Reviews;
using Xunit;
using static commercetools.Api.IntegrationTests.Review.ReviewFixtures;

namespace commercetools.Api.IntegrationTests.Review
{
    [Collection("Integration Tests")]
    public class ReviewIntegrationTests
    {
        private readonly ProjectApiRoot _client;
        private readonly string _projectKey;

        public ReviewIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            this._client = serviceProviderFixture.GetService<ProjectApiRoot>();
        }

        [Fact]
        public async Task CreateReview()
        {
            var key = $"CreateReview-{TestingUtility.RandomString()}";
            await WithReview(
                _client, reviewDraft => DefaultReviewDraftWithKey(reviewDraft, key),
                review => { Assert.Equal(key, review.Key); }
            );
        }

        [Fact]
        public async Task GetReviewById()
        {
            var key = $"GetReviewById-{TestingUtility.RandomString()}";
            await WithReview(
                _client,
                reviewDraft => DefaultReviewDraftWithKey(reviewDraft, key),
                async review =>
                {
                    Assert.NotNull(review);
                    var retrievedReview = await _client
                        .Reviews()
                        .WithId(review.Id)
                        .Get()
                        .ExecuteAsync();

                    Assert.NotNull(retrievedReview);
                    Assert.Equal(key, retrievedReview.Key);
                }
            );
        }

        [Fact]
        public async Task QueryReview()
        {
            var key = $"QueryReview-{TestingUtility.RandomString()}";
            await WithReview(
                _client,
                reviewDraft => DefaultReviewDraftWithKey(reviewDraft, key),
                async review =>
                {
                    Assert.NotNull(review);
                    var returnedSet = await _client
                        .Reviews()
                        .Get()
                        .WithQuery(q => q.Key().Is(review.Key))
                        .ExecuteAsync();

                    Assert.Single(returnedSet.Results);
                    Assert.Equal(key, returnedSet.Results[0].Key);
                });
        }

        [Fact]
        public async Task UpdateReviewByIdChangeTitle()
        {
            await WithUpdateableReview(
                _client,
                async review =>
                {
                    Assert.NotNull(review);
                    var name = $"Test-Title-{TestingUtility.RandomString()}";
                    var action = new ReviewSetTitleAction()
                    {
                        Action = "setTitle",
                        Title = name
                    };

                    var update = new ReviewUpdate()
                    {
                        Version = review.Version,
                        Actions = new List<IReviewUpdateAction>() { action }
                    };

                    var updatedReview = await _client
                        .Reviews()
                        .WithId(review.Id)
                        .Post(update)
                        .ExecuteAsync();

                    Assert.Equal(updatedReview.Title, name);
                    return updatedReview;
                }
            );
        }
    }
}