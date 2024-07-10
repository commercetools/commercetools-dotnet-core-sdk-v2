using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class StagedOrderUpdateAction : IStagedOrderUpdateAction
    {
        public string Action { get; set; }
    }
}
