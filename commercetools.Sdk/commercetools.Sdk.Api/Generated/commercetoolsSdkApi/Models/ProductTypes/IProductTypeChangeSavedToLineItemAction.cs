using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeSavedToLineItemAction))]
    public partial interface IProductTypeChangeSavedToLineItemAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        bool SavedToLineItem { get; set; }

    }
}
