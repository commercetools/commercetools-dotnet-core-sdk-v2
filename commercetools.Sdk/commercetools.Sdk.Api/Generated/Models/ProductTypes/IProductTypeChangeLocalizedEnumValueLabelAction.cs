using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelAction))]
    public partial interface IProductTypeChangeLocalizedEnumValueLabelAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IAttributeLocalizedEnumValue NewValue { get; set; }
    }
}
