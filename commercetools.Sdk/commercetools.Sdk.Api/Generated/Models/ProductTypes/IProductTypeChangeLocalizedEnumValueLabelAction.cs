using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelAction))]
    public partial interface IProductTypeChangeLocalizedEnumValueLabelAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IAttributeLocalizedEnumValue NewValue { get; set; }

    }
}
