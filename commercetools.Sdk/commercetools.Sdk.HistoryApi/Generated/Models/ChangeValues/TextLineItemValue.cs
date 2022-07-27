using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class TextLineItemValue : ITextLineItemValue
    {
        public string Id { get; set; }

        public ILocalizedString Name { get; set; }
    }
}
