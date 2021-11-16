using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeAddLocalizedEnumValueAction))]
    public partial interface IProductTypeAddLocalizedEnumValueAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IAttributeLocalizedEnumValue Value { get; set; }
    }
}
