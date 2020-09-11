using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyPaymentChangeAmountPlannedAction : MyPaymentUpdateAction
    {
        public Money Amount { get; set;}
    }
}
