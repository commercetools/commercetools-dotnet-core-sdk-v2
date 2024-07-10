using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyPaymentSetMethodInfoNameAction : IMyPaymentSetMethodInfoNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public MyPaymentSetMethodInfoNameAction()
        {
            this.Action = "setMethodInfoName";
        }
    }
}
