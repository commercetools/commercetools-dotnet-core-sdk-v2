using commercetools.Sdk.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditSetKeyAction : IOrderEditSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public OrderEditSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
