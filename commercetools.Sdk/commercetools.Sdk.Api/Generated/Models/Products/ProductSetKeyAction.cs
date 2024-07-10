using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetKeyAction : IProductSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public ProductSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
