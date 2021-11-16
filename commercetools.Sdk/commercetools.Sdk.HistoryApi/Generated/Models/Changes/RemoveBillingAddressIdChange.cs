using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveBillingAddressIdChange : IRemoveBillingAddressIdChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public List<string> NextValue { get; set;}
        
        public List<string> PreviousValue { get; set;}
        
        public IAddress Address { get; set;}
        public RemoveBillingAddressIdChange()
        { 
           this.Type = "RemoveBillingAddressIdChange";
        }
    }
}
