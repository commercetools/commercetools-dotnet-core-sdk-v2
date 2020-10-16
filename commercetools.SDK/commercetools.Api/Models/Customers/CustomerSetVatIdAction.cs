using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setVatId")]
    public partial class CustomerSetVatIdAction : CustomerUpdateAction
    {
        public string VatId { get; set;}
        public CustomerSetVatIdAction()
        { 
           this.Action = "setVatId";
        }
    }
}
