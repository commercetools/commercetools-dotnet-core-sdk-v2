using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class TextLineItemValue : ITextLineItemValue
    {
        public string Id { get; set;}
        
        public ILocalizedString Name { get; set;}
    }
}
