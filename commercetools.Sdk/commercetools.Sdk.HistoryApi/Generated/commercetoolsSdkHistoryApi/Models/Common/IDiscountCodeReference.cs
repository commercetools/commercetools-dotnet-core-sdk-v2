using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.DiscountCodeReference))]
    public partial interface IDiscountCodeReference : IReference
    {
        new string Id { get; set; }

    }
}
