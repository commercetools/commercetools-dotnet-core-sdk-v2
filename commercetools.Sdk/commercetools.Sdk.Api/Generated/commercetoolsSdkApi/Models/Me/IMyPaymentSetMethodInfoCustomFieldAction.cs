using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentSetMethodInfoCustomFieldAction))]
    public partial interface IMyPaymentSetMethodInfoCustomFieldAction : IMyPaymentUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
