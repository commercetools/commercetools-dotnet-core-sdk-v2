using commercetools.Api.Models.Me;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartAddPaymentAction))]
    public partial interface IMyCartAddPaymentAction : IMyCartUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set;}
    }
}
