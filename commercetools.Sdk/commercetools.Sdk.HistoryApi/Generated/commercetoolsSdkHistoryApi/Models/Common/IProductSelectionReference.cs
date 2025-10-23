using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductSelectionReference))]
    public partial interface IProductSelectionReference : IReference
    {
        new string Id { get; set; }

    }
}
