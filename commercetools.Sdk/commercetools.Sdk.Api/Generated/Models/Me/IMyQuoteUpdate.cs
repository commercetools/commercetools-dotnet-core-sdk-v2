using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyQuoteUpdate))]
    public partial interface IMyQuoteUpdate
    {
        long Version { get; set; }

        IList<IMyQuoteUpdateAction> Actions { get; set; }
        IEnumerable<IMyQuoteUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
