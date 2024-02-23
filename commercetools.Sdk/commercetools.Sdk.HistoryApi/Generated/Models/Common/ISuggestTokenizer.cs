using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.SuggestTokenizer))]
    public partial interface ISuggestTokenizer
    {
        string Type { get; set; }

    }
}
