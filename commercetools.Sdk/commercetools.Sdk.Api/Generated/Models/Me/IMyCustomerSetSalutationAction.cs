using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetSalutationAction))]
    public partial interface IMyCustomerSetSalutationAction : IMyCustomerUpdateAction
    {
        string Salutation { get; set; }
    }
}
