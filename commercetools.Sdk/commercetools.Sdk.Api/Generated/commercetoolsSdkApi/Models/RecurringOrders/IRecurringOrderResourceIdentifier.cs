using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderResourceIdentifier))]
    public partial interface IRecurringOrderResourceIdentifier : IResourceIdentifier
    {
        new string Id { get; set; }

        new string Key { get; set; }

    }
}
