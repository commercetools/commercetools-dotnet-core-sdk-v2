using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentAddInterfaceInteractionAction : IPaymentAddInterfaceInteractionAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public PaymentAddInterfaceInteractionAction()
        {
            this.Action = "addInterfaceInteraction";
        }
    }
}
