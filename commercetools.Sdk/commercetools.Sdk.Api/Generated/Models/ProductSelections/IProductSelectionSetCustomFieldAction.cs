using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionSetCustomFieldAction))]
    public partial interface IProductSelectionSetCustomFieldAction : IProductSelectionUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
