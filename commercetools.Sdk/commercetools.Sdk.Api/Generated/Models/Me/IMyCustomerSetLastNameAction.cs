using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetLastNameAction))]
    public partial interface IMyCustomerSetLastNameAction : IMyCustomerUpdateAction
    {
        string LastName { get; set; }

    }
}
