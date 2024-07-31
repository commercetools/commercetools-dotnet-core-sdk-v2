using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteUpdate))]
    public partial interface IQuoteUpdate
    {
        long Version { get; set; }

        IList<IQuoteUpdateAction> Actions { get; set; }

        IEnumerable<IQuoteUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
