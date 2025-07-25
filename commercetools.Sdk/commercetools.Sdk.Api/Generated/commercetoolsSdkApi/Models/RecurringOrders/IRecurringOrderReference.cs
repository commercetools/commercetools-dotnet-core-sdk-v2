using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderReference))]
    public partial interface IRecurringOrderReference : IReference
    {
        IRecurringOrder Obj { get; set; }

        new string Id { get; set; }

    }
}
