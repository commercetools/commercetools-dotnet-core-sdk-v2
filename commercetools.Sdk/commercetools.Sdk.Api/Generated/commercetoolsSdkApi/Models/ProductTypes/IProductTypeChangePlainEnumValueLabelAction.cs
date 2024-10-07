using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueLabelAction))]
    public partial interface IProductTypeChangePlainEnumValueLabelAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IAttributePlainEnumValue NewValue { get; set; }

    }
}
