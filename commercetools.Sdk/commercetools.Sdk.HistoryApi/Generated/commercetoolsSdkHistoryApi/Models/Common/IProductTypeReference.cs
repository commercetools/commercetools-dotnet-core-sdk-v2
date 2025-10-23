using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductTypeReference))]
    public partial interface IProductTypeReference : IReference
    {
        new string Id { get; set; }

    }
}
