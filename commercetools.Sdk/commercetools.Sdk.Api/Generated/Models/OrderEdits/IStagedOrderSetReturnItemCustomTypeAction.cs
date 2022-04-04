using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnItemCustomTypeAction))]
    public partial interface IStagedOrderSetReturnItemCustomTypeAction : IStagedOrderUpdateAction
    {
        string ReturnItemId { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }
    }
}
