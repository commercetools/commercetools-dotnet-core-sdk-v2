using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.TaxPortion))]
    public partial interface ITaxPortion
    {
        string Name { get; set; }

        decimal Rate { get; set; }

        ITypedMoney Amount { get; set; }
    }
}
