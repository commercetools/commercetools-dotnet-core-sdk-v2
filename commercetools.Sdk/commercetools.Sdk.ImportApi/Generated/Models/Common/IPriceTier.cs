using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Common.PriceTier))]
    public partial interface IPriceTier
    {
        long MinimumQuantity { get; set; }

        ITypedMoney Value { get; set; }
    }
}
