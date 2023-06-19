using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionDraft))]
    public partial interface IProductSelectionDraft
    {
        string Key { get; set; }

        ILocalizedString Name { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        IProductSelectionTypeEnum Type { get; set; }

        IProductSelectionMode Mode { get; set; }

    }
}
