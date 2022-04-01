using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddLocalizedEnumValueAction))]
    public partial interface IProductTypeAddLocalizedEnumValueAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IAttributeLocalizedEnumValue Value { get; set; }
    }
}
