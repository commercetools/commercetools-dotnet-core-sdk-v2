using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLPriceChangedError))]
    public partial interface IGraphQLPriceChangedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IList<string> LineItems { get; set; }
        IEnumerable<string> LineItemsEnumerable { set => LineItems = value.ToList(); }


        bool Shipping { get; set; }

    }
}
