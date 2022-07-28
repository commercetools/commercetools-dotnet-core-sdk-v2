using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.PriceTier))]
    public partial interface IPriceTier
    {
        long MinimumQuantity { get; set; }

        ITypedMoney Value { get; set; }

    }
}
