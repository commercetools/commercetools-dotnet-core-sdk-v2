using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setDeleteDaysAfterLastModification")]
    public partial class MyCartSetDeleteDaysAfterLastModificationAction : MyCartUpdateAction
    {
        public int DeleteDaysAfterLastModification { get; set;}
        public MyCartSetDeleteDaysAfterLastModificationAction()
        { 
           this.Action = "setDeleteDaysAfterLastModification";
        }
    }
}
