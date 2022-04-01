using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetCustomFieldAction))]
    public partial interface IProductSelectionSetCustomFieldAction : IProductSelectionUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
