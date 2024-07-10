using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeRemoveEnumValuesAction : IProductTypeRemoveEnumValuesAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public IList<string> Keys { get; set; }
        public IEnumerable<string> KeysEnumerable { set => Keys = value.ToList(); }

        public ProductTypeRemoveEnumValuesAction()
        {
            this.Action = "removeEnumValues";
        }
    }
}
