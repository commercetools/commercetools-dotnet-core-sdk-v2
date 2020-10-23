using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class CartSetDeleteDaysAfterLastModificationAction : ICartSetDeleteDaysAfterLastModificationAction
    {
        public string Action { get; set;}
        
        public int DeleteDaysAfterLastModification { get; set;}
        public CartSetDeleteDaysAfterLastModificationAction()
        { 
           this.Action = "setDeleteDaysAfterLastModification";
        }
    }
}
