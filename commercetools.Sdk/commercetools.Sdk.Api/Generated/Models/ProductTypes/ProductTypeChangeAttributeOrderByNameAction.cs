using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangeAttributeOrderByNameAction : IProductTypeChangeAttributeOrderByNameAction
    {
        public string Action { get; set; }

        public IList<string> AttributeNames { get; set; }
        public IEnumerable<string> AttributeNamesEnumerable { set => AttributeNames = value.ToList(); }

        public ProductTypeChangeAttributeOrderByNameAction()
        {
            this.Action = "changeAttributeOrderByName";
        }
    }
}
