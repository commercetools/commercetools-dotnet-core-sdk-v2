using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.PriceTierDraft))]
    public partial interface IPriceTierDraft
    {
        long MinimumQuantity { get; set; }

        IMoney Value { get; set; }
    }
}
