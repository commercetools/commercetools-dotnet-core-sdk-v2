using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerSetSalutationAction))]
    public partial interface IMyCustomerSetSalutationAction : IMyCustomerUpdateAction
    {
        string Salutation { get; set;}
    }
}
