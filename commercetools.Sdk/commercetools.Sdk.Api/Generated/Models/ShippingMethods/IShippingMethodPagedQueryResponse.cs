using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodPagedQueryResponse))]
    public partial interface IShippingMethodPagedQueryResponse
    {
        long? Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long? Offset { get; set; }

        IList<IShippingMethod> Results { get; set; }
        IEnumerable<IShippingMethod> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
