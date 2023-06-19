using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.AsAssociate
{
    public class ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyQuotesTest : RequestBuilderParentTests
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void WithMethods(HttpRequestMessage request, string httpMethod, string uri)
        {
            Assert.Equal(httpMethod.ToLower(), request.Method.Method.ToLower());
            Assert.Equal(uri.ToLower(), request.RequestUri.ToString().ToLower());
        }

        public static IEnumerable<object[]> GetData()
        {
            return new List<object[]> {
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Quotes()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/quotes?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Quotes()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/quotes?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Quotes()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/quotes?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Quotes()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/quotes?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Quotes()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/quotes?withTotal=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Quotes()
                   .Get()
                   .WithWhere("where")
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/quotes?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Quotes()
                   .Get()
                   .WithPredicateVar("varName", "var.varName")
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/quotes?var.varName=var.varName",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Quotes()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/quotes",
               }
       };
        }
    }
}
