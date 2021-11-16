using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelAction))]
    public partial interface IProductTypeChangeLocalizedEnumValueLabelAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set;}
        
        IAttributeLocalizedEnumValue NewValue { get; set;}
    }
}
