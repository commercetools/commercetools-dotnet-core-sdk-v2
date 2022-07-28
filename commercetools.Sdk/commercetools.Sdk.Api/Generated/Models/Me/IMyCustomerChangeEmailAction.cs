using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerChangeEmailAction))]
    public partial interface IMyCustomerChangeEmailAction : IMyCustomerUpdateAction
    {
        string Email { get; set; }

    }
}
