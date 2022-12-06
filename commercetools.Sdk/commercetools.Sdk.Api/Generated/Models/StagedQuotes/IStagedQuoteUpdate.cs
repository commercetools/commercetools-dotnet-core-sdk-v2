using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteUpdate))]
    public partial interface IStagedQuoteUpdate
    {
        long Version { get; set; }

        IList<IStagedQuoteUpdateAction> Actions { get; set; }
        IEnumerable<IStagedQuoteUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
