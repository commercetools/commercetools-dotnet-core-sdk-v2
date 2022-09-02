using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetDateOfBirthAction))]
    public partial interface IMyCustomerSetDateOfBirthAction : IMyCustomerUpdateAction
    {
        Date? DateOfBirth { get; set; }

    }
}
