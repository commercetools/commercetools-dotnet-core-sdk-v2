using commercetools.Sdk.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class AttributeMoneyType : IAttributeMoneyType
    {
        public string Name { get; set; }
        public AttributeMoneyType()
        {
            this.Name = "money";
        }
    }
}
