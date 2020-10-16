using Xunit;
using commercetools.Api.Client;
using System.Net.Http;
using System.Collections.Generic;
using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Serialization;
using commercetools.Base.Client;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Api.Tests
{
    public class RequestBuilderTests
    {
        private IClient GetClient()
        {
            var s = new ServiceCollection();
            s.UseCommercetoolsApiSerialization();
            var p = s.BuildServiceProvider();
            
            return new CtpClient(null, p.GetService<SerializerService>());
        }
        
        [Fact]
        public void TestGetByIdRequest()
        {
            //arrange
            var projectKey = "test-proj";
            var categoryId = "a147c01f-8789-4289-bcac-07a0f8dc4198";
            var expand1 = "parent";
            var expand2 = "ancestors";
            var additionalParam = new KeyValuePair<string, string>("withTotal", "false");

            //act
            var request = GetClient().ApiRoot()
                            .WithProjectKey(projectKey)
                            .Categories()
                            .WithId(categoryId)
                            .Get()
                            .WithExpand(expand1)
                            .WithExpand(expand2)
                            .AddQueryParam(additionalParam.Key, additionalParam.Value)
                            .Build();
            

            var expectedRequestUrl = $"/{projectKey}/categories/{categoryId}?" +
                $"expand={expand1}&expand={expand2}&{additionalParam.Key}={additionalParam.Value}";
            //assert
            Assert.NotNull(request);
            Assert.Equal(HttpMethod.Get,request.Method);
            Assert.Equal(expectedRequestUrl, request.RequestUri.ToString());
        }

        [Fact]
        public void TestQueryRequest()
        {
            //arrange
            var projectKey = "test-proj";
            var limit = 10;
            var offset = 5;
            var withTotal = false;
            var expand = "parent";
            var where = $"name = \"food\"";
            
            //act
            var request = GetClient().ApiRoot()
                            .WithProjectKey(projectKey)
                            .Categories()
                            .Get()
                            .WithExpand(expand)
                            .WithLimit(limit)
                            .WithOffset(offset)
                            .WithWithTotal(withTotal)
                            .WithWhere(where)
                            .Build();


            var expectedRequestUrl = $"/{projectKey}/categories?" +
                $"expand={expand}&limit={limit}&offset={offset}" +
                $"&withTotal={withTotal}&where=name%20%3D%20%22food%22";
            
            //assert
            Assert.NotNull(request);
            Assert.Equal(HttpMethod.Get, request.Method);
            Assert.Equal(expectedRequestUrl, request.RequestUri.ToString());
        }

        [Fact]
        public void TestDeleteByIdRequest()
        {
            //arrange
            var projectKey = "test-proj";
            var categoryId = "a147c01f-8789-4289-bcac-07a0f8dc4198";
            var expand1 = "parent";
            var expand2 = "ancestors";
            var additionalParam = new KeyValuePair<string, string>("withTotal", "false");

            //act
            var request = GetClient().ApiRoot()
                            .WithProjectKey(projectKey)
                            .Categories()
                            .WithId(categoryId)
                            .Delete()
                            .WithVersion(2)
                            .WithExpand(expand1)
                            .WithExpand(expand2)
                            .AddQueryParam(additionalParam.Key, additionalParam.Value)
                            .Build();


            var expectedRequestUrl = $"/{projectKey}/categories/{categoryId}?" +
                $"version=2&expand={expand1}&expand={expand2}&{additionalParam.Key}={additionalParam.Value}";
            //assert
            Assert.NotNull(request);
            Assert.Equal(HttpMethod.Delete, request.Method);
            Assert.Equal(expectedRequestUrl, request.RequestUri.ToString());
        }

        [Fact]
        public void TestUpdateByIdRequest()
        {
            //arrange
            var projectKey = "test-proj";
            var categoryId = "a147c01f-8789-4289-bcac-07a0f8dc4198";
            var expand1 = "parent";
            var expand2 = "ancestors";
            var additionalParam = new KeyValuePair<string, string>("withTotal", "false");
            var categoryUpdate = new CategoryUpdate()
            {
                Version = 2,
                Actions = new List<CategoryUpdateAction>
                {
                    new CategoryChangeOrderHintAction
                    {
                        OrderHint = "0.12",
                        Action = "changeOrderHint"
                    }
                }
            };

           
            //act
            var request = GetClient().ApiRoot()
                            .WithProjectKey(projectKey)
                            .Categories()
                            .WithId(categoryId)
                            .Post(categoryUpdate)
                            .WithExpand(expand1)
                            .WithExpand(expand2)
                            .AddQueryParam(additionalParam.Key, additionalParam.Value)
                            .Build();


            var expectedRequestUrl = $"/{projectKey}/categories/{categoryId}?" +
                $"expand={expand1}&expand={expand2}&{additionalParam.Key}={additionalParam.Value}";
            //assert
            Assert.NotNull(request);
            Assert.Equal(HttpMethod.Post, request.Method);
            Assert.Equal(expectedRequestUrl, request.RequestUri.ToString());
            var content = request.Content.ReadAsStringAsync().Result;
            Assert.NotNull(content);
        }

        [Fact]
        public void TestCreateRequest()
        {
            //arrange
            var projectKey = "test-proj";
            
            var categoryDraft = new CategoryDraft
            {
                Name = new LocalizedString { { "en", "Name" } },
                Key = "key"
            };

            //act
            var request = GetClient().ApiRoot()
                            .WithProjectKey(projectKey)
                            .Categories()
                            .Post(categoryDraft)
                            .Build();


            var expectedRequestUrl = $"/{projectKey}/categories";
            //assert
            Assert.NotNull(request);
            Assert.Equal(HttpMethod.Post, request.Method);
            Assert.Equal(expectedRequestUrl, request.RequestUri.ToString());
            var content = request.Content.ReadAsStringAsync().Result;
            Assert.NotNull(content);
        }
    }
}
