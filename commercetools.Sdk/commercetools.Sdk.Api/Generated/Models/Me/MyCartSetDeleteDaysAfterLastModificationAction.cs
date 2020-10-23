using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public  partial class MyCartSetDeleteDaysAfterLastModificationAction : IMyCartSetDeleteDaysAfterLastModificationAction
    {
        public string Action { get; set;}
        
        public int DeleteDaysAfterLastModification { get; set;}
        public MyCartSetDeleteDaysAfterLastModificationAction()
        { 
           this.Action = "setDeleteDaysAfterLastModification";
        }
    }
}
