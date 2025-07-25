using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetCustomLineItemRecurrenceInfoAction))]
    public partial interface IMyCartSetCustomLineItemRecurrenceInfoAction : IMyCartUpdateAction
    {
        string CustomLineItemId { get; set; }

        string CustomLineItemKey { get; set; }

        ICustomLineItemRecurrenceInfoDraft RecurrenceInfo { get; set; }

    }
}
