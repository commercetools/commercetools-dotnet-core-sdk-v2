using commercetools.Base.Models;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetDateOfBirthAction))]
    public partial interface IMyCustomerSetDateOfBirthAction : IMyCustomerUpdateAction
    {
        Date? DateOfBirth { get; set; }

    }
}
