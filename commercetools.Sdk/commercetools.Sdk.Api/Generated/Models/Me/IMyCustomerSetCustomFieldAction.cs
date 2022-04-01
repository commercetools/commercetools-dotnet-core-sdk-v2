using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetCustomFieldAction))]
    public partial interface IMyCustomerSetCustomFieldAction : IMyCustomerUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
