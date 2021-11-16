using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetCustomLineItemTaxCategoryChange : ISetCustomLineItemTaxCategoryChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ILocalizedString CustomLineItem { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public IReference NextValue { get; set;}
        
        public IReference PreviousValue { get; set;}
        public SetCustomLineItemTaxCategoryChange()
        { 
           this.Type = "SetCustomLineItemTaxCategoryChange";
        }
    }
}
