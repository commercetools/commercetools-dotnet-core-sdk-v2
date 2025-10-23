using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CartDiscountTarget))]
    public partial interface ICartDiscountTarget
    {
        string Type { get; set; }

    }
}
