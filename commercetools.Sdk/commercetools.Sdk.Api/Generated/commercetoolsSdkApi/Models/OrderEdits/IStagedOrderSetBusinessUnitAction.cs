using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBusinessUnitAction))]
    public partial interface IStagedOrderSetBusinessUnitAction : IStagedOrderUpdateAction
    {
        IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

    }
}
