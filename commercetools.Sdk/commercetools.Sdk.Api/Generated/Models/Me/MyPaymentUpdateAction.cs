using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyPaymentUpdateAction : IMyPaymentUpdateAction
    {
        public string Action { get; set;}
    }
}
