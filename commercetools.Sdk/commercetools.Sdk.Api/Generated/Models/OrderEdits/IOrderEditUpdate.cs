using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditUpdate))]
    public partial interface IOrderEditUpdate
    {
        long Version { get; set; }

        IList<IOrderEditUpdateAction> Actions { get; set; }
        IEnumerable<IOrderEditUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


        bool? DryRun { get; set; }

    }
}
