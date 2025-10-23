using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductDiscountReference))]
    public partial interface IProductDiscountReference : IReference
    {
        new string Id { get; set; }

    }
}
