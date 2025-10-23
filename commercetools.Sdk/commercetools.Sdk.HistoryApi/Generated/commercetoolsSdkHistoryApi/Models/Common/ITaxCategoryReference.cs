using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.TaxCategoryReference))]
    public partial interface ITaxCategoryReference : IReference
    {
        new string Id { get; set; }

    }
}
