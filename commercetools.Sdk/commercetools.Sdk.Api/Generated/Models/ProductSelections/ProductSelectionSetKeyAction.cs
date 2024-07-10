using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionSetKeyAction : IProductSelectionSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public ProductSelectionSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
