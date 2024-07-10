using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using commercetools.Sdk.Api.Tests;
using commercetools.Sdk.Api.Models;
using commercetools.Sdk.Api.Models.Common;
using Xunit;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Tests.Client.RequestBuilders.AsAssociate
{
    public class ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyCartsTest : RequestBuilderParentTests
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
                   .Carts()
                   .Get()
                   .WithExpand("expand")
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/carts?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Carts()
                   .Get()
                   .WithSort("sort")
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/carts?sort=sort",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Carts()
                   .Get()
                   .WithLimit(7)
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/carts?limit=7",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Carts()
                   .Get()
                   .WithOffset(3)
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/carts?offset=3",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Carts()
                   .Get()
                   .WithWithTotal(true)
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/carts?withTotal=true",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Carts()
                   .Get()
                   .WithWhere("where")
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/carts?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Carts()
                   .Get()
                   .WithPredicateVar("varName", "var.varName")
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/carts?var.varName=var.varName",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Carts()
                   .Get()
                   .Build(),
                   "Get",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/carts",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Carts()
                   .Head()
                   .WithWhere("where")
                   .Build(),
                   "Head",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/carts?where=where",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Carts()
                   .Head()
                   .Build(),
                   "Head",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/carts",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Carts()
                   .Post(null)
                   .WithExpand("expand")
                   .Build(),
                   "Post",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/carts?expand=expand",
               },
               new Object[] {
                   ApiRoot
                   .WithProjectKey("test_projectKey")
                   .AsAssociate()
                   .WithAssociateIdValue("test_associateId")
                   .InBusinessUnitKeyWithBusinessUnitKeyValue("test_businessUnitKey")
                   .Carts()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/as-associate/test_associateId/in-business-unit/key=test_businessUnitKey/carts",
               }
       };
        }
    }
}
