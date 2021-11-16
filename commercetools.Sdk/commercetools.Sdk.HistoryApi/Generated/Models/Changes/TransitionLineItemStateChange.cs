using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class TransitionLineItemStateChange : ITransitionLineItemStateChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string LineItemId { get; set;}
        
        public string StateId { get; set;}
        
        public List<IItemState> NextValue { get; set;}
        
        public List<IItemState> PreviousValue { get; set;}
        public TransitionLineItemStateChange()
        { 
           this.Type = "TransitionLineItemStateChange";
        }
    }
}
