using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderTransitionStateAction))]
    public partial interface IStagedOrderTransitionStateAction : IStagedOrderUpdateAction
    {
        IStateResourceIdentifier State { get; set; }

        bool? Force { get; set; }

    }
}
