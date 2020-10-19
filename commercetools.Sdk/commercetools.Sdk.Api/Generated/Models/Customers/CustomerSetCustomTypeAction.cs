using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setCustomType")]
    public partial class CustomerSetCustomTypeAction : CustomerUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public CustomerSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
