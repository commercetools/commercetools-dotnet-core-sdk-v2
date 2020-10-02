using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setExternalId")]
    public partial class CustomerSetExternalIdAction : CustomerUpdateAction
    {
        public string ExternalId { get; set;}
        public CustomerSetExternalIdAction()
        { 
           this.Action = "setExternalId";
        }
    }
}
