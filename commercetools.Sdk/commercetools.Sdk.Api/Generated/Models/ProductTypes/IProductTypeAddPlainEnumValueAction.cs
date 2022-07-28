using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddPlainEnumValueAction))]
    public partial interface IProductTypeAddPlainEnumValueAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IAttributePlainEnumValue Value { get; set; }

    }
}
