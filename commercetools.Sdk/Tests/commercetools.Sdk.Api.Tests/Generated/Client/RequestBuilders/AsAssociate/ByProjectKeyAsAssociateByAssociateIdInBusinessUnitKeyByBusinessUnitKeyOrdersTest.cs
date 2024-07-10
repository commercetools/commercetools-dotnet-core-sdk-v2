using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.AsAssociate
{
    public class ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersTest : RequestBuilderParentTests
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
                   .Orders()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/orders?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Orders()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/orders?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Orders()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/orders?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Orders()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/orders?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Orders()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/orders?withTotal=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Orders()
                   .Get()
                   .WithWhere("where")
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/orders?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Orders()
                   .Get()
                   .WithPredicateVar("varName", "var.varName")
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/orders?var.varName=var.varName",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Orders()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/orders",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Orders()
                   .Head()
                   .WithWhere("where")
                   .Build(),
                   "Head",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/orders?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Orders()
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/orders",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Orders()
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/orders?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Orders()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/orders",
               }
       };
        }
    }
}
