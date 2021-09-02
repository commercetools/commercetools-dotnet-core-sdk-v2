using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeChangeAttributeOrderByNameAction : IProductTypeChangeAttributeOrderByNameAction
    {
        public string Action { get; set; }

        public List<string> AttributeNames { get; set; }
        public ProductTypeChangeAttributeOrderByNameAction()
        {
            this.Action = "changeAttributeOrderByName";
        }
    }
}
