using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetApplicationStatusUpdateAction))]
    public partial interface ISetApplicationStatusUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        IApplicationStatus Status { get; set; }

    }
}
