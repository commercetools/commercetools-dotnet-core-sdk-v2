using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListSetDeleteDaysAfterLastModificationAction))]
    public partial interface IMyShoppingListSetDeleteDaysAfterLastModificationAction : IMyShoppingListUpdateAction
    {
        long? DeleteDaysAfterLastModification { get; set;}
    }
}
