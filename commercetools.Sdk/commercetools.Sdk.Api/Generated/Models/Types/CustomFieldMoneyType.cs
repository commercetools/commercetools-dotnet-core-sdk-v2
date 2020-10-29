using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldMoneyType : ICustomFieldMoneyType
    {
        public string Name { get; set;}
        public CustomFieldMoneyType()
        { 
           this.Name = "Money";
        }
    }
}
