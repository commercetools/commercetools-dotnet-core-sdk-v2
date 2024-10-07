using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetTitleAction))]
    public partial interface IMyCustomerSetTitleAction : IMyCustomerUpdateAction
    {
        string Title { get; set; }

    }
}
