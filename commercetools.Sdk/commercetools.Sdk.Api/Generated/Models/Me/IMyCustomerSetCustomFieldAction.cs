using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerSetCustomFieldAction))]
    public partial interface IMyCustomerSetCustomFieldAction : IMyCustomerUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
