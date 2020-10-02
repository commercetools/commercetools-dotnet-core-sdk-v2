using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("money")]
    public partial class AttributeMoneyType : AttributeType
    {
        public AttributeMoneyType()
        { 
           this.Name = "money";
        }
    }
}
