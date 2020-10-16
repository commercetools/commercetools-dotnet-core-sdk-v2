using commercetools.Api.Models.Payments;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("addInterfaceInteraction")]
    public partial class PaymentAddInterfaceInteractionAction : PaymentUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public PaymentAddInterfaceInteractionAction()
        { 
           this.Action = "addInterfaceInteraction";
        }
    }
}
