using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeValueGiftLineItemChangeValue))]
    public partial interface IChangeValueGiftLineItemChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set; }

        IReference Product { get; set; }

        int VariantId { get; set; }

        IReference SupplyChannel { get; set; }

        IReference DistributionChannel { get; set; }
    }
}
