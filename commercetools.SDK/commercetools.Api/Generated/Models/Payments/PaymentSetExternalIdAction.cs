using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setExternalId")]
    public partial class PaymentSetExternalIdAction : PaymentUpdateAction
    {
        public string ExternalId { get; set;}
        public PaymentSetExternalIdAction()
        { 
           this.Action = "setExternalId";
        }
    }
}
