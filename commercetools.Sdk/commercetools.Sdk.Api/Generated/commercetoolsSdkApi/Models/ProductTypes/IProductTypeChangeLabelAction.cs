using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLabelAction))]
    public partial interface IProductTypeChangeLabelAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        ILocalizedString Label { get; set; }

    }
}
