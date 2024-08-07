using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetCustomerEmailAction))]
    public partial interface IMyCartSetCustomerEmailAction : IMyCartUpdateAction
    {
        string Email { get; set; }

    }
}
