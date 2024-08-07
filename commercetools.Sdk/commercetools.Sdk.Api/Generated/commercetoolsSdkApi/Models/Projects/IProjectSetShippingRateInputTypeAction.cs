using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetShippingRateInputTypeAction))]
    public partial interface IProjectSetShippingRateInputTypeAction : IProjectUpdateAction
    {
        IShippingRateInputType ShippingRateInputType { get; set; }

    }
}
