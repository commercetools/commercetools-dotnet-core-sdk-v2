using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.Counter))]
    public partial interface ICounter : ISkipConfiguration
    {
        int TotalToSkip { get; set; }

        int Skipped { get; set; }

        DateTime? LastSkippedAt { get; set; }

    }
}
