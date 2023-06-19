using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetFirstNameAction))]
    public partial interface IMyCustomerSetFirstNameAction : IMyCustomerUpdateAction
    {
        string FirstName { get; set; }

    }
}
