using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setDeleteDaysAfterLastModification")]
    public partial class CartSetDeleteDaysAfterLastModificationAction : CartUpdateAction
    {
        public int DeleteDaysAfterLastModification { get; set;}
        public CartSetDeleteDaysAfterLastModificationAction()
        { 
           this.Action = "setDeleteDaysAfterLastModification";
        }
    }
}
