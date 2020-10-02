using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeName")]
    public partial class MyShoppingListChangeNameAction : MyShoppingListUpdateAction
    {
        public LocalizedString Name { get; set;}
        public MyShoppingListChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
