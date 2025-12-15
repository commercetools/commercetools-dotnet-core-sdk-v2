using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.DirectDiscount))]
    public partial interface IDirectDiscount
    {
        string Id { get; set; }

        ICartDiscountValue Value { get; set; }

        ICartDiscountTarget Target { get; set; }

    }
}
