using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeAmountPlanned")]
    public class MyPaymentChangeAmountPlannedAction : MyPaymentUpdateAction
    {
        public Money Amount { get; set;}
    }
}
