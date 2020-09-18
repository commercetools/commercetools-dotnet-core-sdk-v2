using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setDeleteDaysAfterLastModification")]
    public class MyCartSetDeleteDaysAfterLastModificationAction : MyCartUpdateAction
    {
        public int DeleteDaysAfterLastModification { get; set;}
    }
}
