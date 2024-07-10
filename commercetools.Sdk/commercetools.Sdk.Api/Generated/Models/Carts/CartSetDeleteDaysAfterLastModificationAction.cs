using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetDeleteDaysAfterLastModificationAction : ICartSetDeleteDaysAfterLastModificationAction
    {
        public string Action { get; set; }

        public int? DeleteDaysAfterLastModification { get; set; }
        public CartSetDeleteDaysAfterLastModificationAction()
        {
            this.Action = "setDeleteDaysAfterLastModification";
        }
    }
}
