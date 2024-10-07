using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetCustomFieldAction))]
    public partial interface IProductSelectionSetCustomFieldAction : IProductSelectionUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
