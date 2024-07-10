using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionDraft))]
    public partial interface IProductSelectionDraft
    {
        string Key { get; set; }

        ILocalizedString Name { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IProductSelectionMode Mode { get; set; }

    }
}
