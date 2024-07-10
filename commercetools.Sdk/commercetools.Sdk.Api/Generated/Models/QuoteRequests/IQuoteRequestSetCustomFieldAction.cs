using commercetools.Sdk.Api.Models.QuoteRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestSetCustomFieldAction))]
    public partial interface IQuoteRequestSetCustomFieldAction : IQuoteRequestUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
