using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetTaxCategoryChange))]
    public partial interface ISetTaxCategoryChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IReference PreviousValue { get; set; }

        IReference NextValue { get; set; }
    }
}
