using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyQuoteRequestDraft))]
    public partial interface IMyQuoteRequestDraft
    {
        string CartId { get; set; }

        long CartVersion { get; set; }

        string Comment { get; set; }

    }
}
