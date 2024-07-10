using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.ProductSelectionSettingDraft))]
    public partial interface IProductSelectionSettingDraft
    {
        IProductSelectionResourceIdentifier ProductSelection { get; set; }

        bool? Active { get; set; }

    }
}
