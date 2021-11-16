using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerSetLastNameAction))]
    public partial interface IMyCustomerSetLastNameAction : IMyCustomerUpdateAction
    {
        string LastName { get; set;}
    }
}
