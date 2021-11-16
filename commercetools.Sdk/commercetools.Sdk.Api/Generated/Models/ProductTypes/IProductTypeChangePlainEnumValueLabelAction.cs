using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueLabelAction))]
    public partial interface IProductTypeChangePlainEnumValueLabelAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IAttributePlainEnumValue NewValue { get; set; }
    }
}
