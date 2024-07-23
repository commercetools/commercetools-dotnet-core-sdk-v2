using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.TaxPortion))]
    public partial interface ITaxPortion
    {
        string Name { get; set; }

        decimal Rate { get; set; }

        ICentPrecisionMoney Amount { get; set; }

    }
}
