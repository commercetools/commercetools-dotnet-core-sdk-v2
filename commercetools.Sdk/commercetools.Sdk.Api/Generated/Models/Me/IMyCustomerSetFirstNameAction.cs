using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerSetFirstNameAction))]
    public partial interface IMyCustomerSetFirstNameAction : IMyCustomerUpdateAction
    {
        string FirstName { get; set;}
    }
}
