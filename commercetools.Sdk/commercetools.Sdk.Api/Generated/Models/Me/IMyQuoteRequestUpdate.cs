using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyQuoteRequestUpdate))]
    public partial interface IMyQuoteRequestUpdate
    {
        long Version { get; set; }

        IList<IMyQuoteRequestUpdateAction> Actions { get; set; }
        IEnumerable<IMyQuoteRequestUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
