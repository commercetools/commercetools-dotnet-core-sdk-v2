using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetCustomFieldAction))]
    public partial interface IMyPaymentSetCustomFieldAction : IMyPaymentUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
