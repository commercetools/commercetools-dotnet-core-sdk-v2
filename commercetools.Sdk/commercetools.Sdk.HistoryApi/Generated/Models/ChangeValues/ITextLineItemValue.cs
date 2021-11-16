using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.TextLineItemValue))]
    public partial interface ITextLineItemValue 
    {
        string Id { get; set;}
        
        ILocalizedString Name { get; set;}
    }
}
