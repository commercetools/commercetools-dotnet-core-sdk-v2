using commercetools.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
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
