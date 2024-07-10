using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.TextLineItem))]
    public partial interface ITextLineItem
    {
        DateTime AddedAt { get; set; }

        ICustomFields Custom { get; set; }

        ILocalizedString Description { get; set; }

        string Id { get; set; }

        string Key { get; set; }

        ILocalizedString Name { get; set; }

        long Quantity { get; set; }

    }
}
