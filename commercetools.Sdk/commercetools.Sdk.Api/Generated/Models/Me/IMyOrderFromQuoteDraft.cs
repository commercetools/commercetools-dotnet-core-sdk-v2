using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyOrderFromQuoteDraft))]
    public partial interface IMyOrderFromQuoteDraft
    {
        string Id { get; set; }

        long Version { get; set; }

        bool? QuoteStateToAccepted { get; set; }

    }
}
