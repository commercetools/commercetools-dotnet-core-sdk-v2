using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetLineItemRecurrenceInfoAction))]
    public partial interface IMyCartSetLineItemRecurrenceInfoAction : IMyCartUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        ILineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }

    }
}
