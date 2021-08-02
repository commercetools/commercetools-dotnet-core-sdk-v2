using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeRequiresDiscountCodeChange : IChangeRequiresDiscountCodeChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public bool PreviousValue { get; set;}
        
        public bool NextValue { get; set;}
        public ChangeRequiresDiscountCodeChange()
        { 
           this.Type = "ChangeRequiresDiscountCodeChange";
        }
    }
}
