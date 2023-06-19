using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributePlainEnumValue))]
    public partial interface IAttributePlainEnumValue
    {
        string Key { get; set; }

        string Label { get; set; }

    }
}
