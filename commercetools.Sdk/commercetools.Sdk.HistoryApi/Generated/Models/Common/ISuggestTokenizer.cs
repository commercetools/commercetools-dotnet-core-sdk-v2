using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.SuggestTokenizer))]
    public partial interface ISuggestTokenizer
    {
        string Type { get; set; }
    }
}
