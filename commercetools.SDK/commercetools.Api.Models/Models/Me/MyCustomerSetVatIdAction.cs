using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setVatId")]
    public partial class MyCustomerSetVatIdAction : MyCustomerUpdateAction
    {
        public string VatId { get; set;}
        public MyCustomerSetVatIdAction()
        { 
           this.Action = "setVatId";
        }
    }
}
