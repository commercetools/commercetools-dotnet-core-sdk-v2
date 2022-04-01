using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetDateOfBirthAction))]
    public partial interface ICustomerSetDateOfBirthAction : ICustomerUpdateAction
    {
        DateTime? DateOfBirth { get; set; }
    }
}
