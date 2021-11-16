using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeCartDiscountsChange : IChangeCartDiscountsChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public List<IReference> PreviousValue { get; set;}
        
        public List<IReference> NextValue { get; set;}
        public ChangeCartDiscountsChange()
        { 
           this.Type = "ChangeCartDiscountsChange";
        }
    }
}
