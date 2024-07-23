using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetMiddleNameAction))]
    public partial interface IMyCustomerSetMiddleNameAction : IMyCustomerUpdateAction
    {
        string MiddleName { get; set; }

    }
}
