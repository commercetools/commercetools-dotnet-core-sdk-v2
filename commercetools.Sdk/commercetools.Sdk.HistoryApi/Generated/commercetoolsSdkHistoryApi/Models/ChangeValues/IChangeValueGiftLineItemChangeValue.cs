using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueGiftLineItemChangeValue))]
    public partial interface IChangeValueGiftLineItemChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set; }

        IReference Product { get; set; }

        int VariantId { get; set; }

        IReference SupplyChannel { get; set; }

        IReference DistributionChannel { get; set; }

    }
}
