using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CartDiscountReference))]
    public partial interface ICartDiscountReference : IReference
    {
        new string Id { get; set; }

    }
}
