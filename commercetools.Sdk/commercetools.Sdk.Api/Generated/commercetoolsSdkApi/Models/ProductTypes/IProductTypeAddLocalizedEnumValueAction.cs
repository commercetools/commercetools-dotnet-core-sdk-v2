using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddLocalizedEnumValueAction))]
    public partial interface IProductTypeAddLocalizedEnumValueAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IAttributeLocalizedEnumValue Value { get; set; }

    }
}
