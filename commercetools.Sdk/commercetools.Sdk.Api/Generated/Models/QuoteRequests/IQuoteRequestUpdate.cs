using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestUpdate))]
    public partial interface IQuoteRequestUpdate
    {
        long Version { get; set; }

        IList<IQuoteRequestUpdateAction> Actions { get; set; }
        IEnumerable<IQuoteRequestUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
