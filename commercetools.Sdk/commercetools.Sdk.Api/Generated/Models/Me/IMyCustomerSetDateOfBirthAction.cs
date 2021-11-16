using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerSetDateOfBirthAction))]
    public partial interface IMyCustomerSetDateOfBirthAction : IMyCustomerUpdateAction
    {
        DateTime? DateOfBirth { get; set;}
    }
}
