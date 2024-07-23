using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetDateOfBirthAction))]
    public partial interface ICustomerSetDateOfBirthAction : ICustomerUpdateAction
    {
        Date? DateOfBirth { get; set; }

    }
}
