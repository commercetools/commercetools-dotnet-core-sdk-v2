using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CategoryReference))]
    public partial interface ICategoryReference : IReference
    {
        new string Id { get; set; }

    }
}
