using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCategoryOrderHintChange))]
    public partial interface ISetCategoryOrderHintChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ICategoryOrderHints PreviousValue { get; set; }

        ICategoryOrderHints NextValue { get; set; }

        string CatalogData { get; set; }

        string CategoryId { get; set; }

    }
}
