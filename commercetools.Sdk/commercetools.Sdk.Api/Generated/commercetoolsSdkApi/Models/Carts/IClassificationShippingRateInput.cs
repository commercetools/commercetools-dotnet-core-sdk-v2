using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInput))]
    public partial interface IClassificationShippingRateInput : IShippingRateInput
    {
        string Key { get; set; }

        ILocalizedString Label { get; set; }

    }
}
