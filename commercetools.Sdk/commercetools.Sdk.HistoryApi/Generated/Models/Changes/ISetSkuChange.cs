using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetSkuChange))]
    public partial interface ISetSkuChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string CatalogData { get; set; }

        string PreviousValue { get; set; }

        string NextValue { get; set; }

    }
}
