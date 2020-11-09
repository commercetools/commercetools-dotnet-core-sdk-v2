using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyPaymentSetMethodInfoNameAction))]
    public partial interface IMyPaymentSetMethodInfoNameAction : IMyPaymentUpdateAction
    {
        ILocalizedString Name { get; set;}
    }
}
