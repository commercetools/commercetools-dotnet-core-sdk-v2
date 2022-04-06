using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ItemShippingDetailsDraft))]
    public partial interface IItemShippingDetailsDraft
    {
        List<IItemShippingTarget> Targets { get; set; }
    }
}
