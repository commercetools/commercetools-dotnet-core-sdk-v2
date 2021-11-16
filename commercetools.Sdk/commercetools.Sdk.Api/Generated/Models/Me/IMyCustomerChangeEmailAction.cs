using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerChangeEmailAction))]
    public partial interface IMyCustomerChangeEmailAction : IMyCustomerUpdateAction
    {
        string Email { get; set;}
    }
}
