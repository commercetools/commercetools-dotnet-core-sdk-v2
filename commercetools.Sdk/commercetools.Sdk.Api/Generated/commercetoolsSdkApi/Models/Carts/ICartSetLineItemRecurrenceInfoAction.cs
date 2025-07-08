using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemRecurrenceInfoAction))]
    public partial interface ICartSetLineItemRecurrenceInfoAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        ILineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }

    }
}
