using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangeLocalizedEnumValueOrderAction : IProductTypeChangeLocalizedEnumValueOrderAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public IList<IAttributeLocalizedEnumValue> Values { get; set; }
        public IEnumerable<IAttributeLocalizedEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

        public ProductTypeChangeLocalizedEnumValueOrderAction()
        {
            this.Action = "changeLocalizedEnumValueOrder";
        }
    }
}
