using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.SuggestTokenizer))]
    public partial interface ISuggestTokenizer
    {
        string Type { get; set; }
    }
}
