using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangePlainEnumValueOrderAction : IProductTypeChangePlainEnumValueOrderAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public IList<IAttributePlainEnumValue> Values { get; set; }
        public IEnumerable<IAttributePlainEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

        public ProductTypeChangePlainEnumValueOrderAction()
        {
            this.Action = "changePlainEnumValueOrder";
        }
    }
}
