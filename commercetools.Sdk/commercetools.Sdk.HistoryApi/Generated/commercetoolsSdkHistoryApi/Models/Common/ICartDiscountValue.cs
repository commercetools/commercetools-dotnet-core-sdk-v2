using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CartDiscountValue))]
    public partial interface ICartDiscountValue
    {
        string Type { get; set; }

    }
}
