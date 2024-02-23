using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeLocalizedEnumValue))]
    public partial interface IAttributeLocalizedEnumValue
    {
        string Key { get; set; }

        ILocalizedString Label { get; set; }

    }
}
