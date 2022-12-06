using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.Update))]
    public partial interface IUpdate
    {
        long Version { get; set; }

        IList<IUpdateAction> Actions { get; set; }
        IEnumerable<IUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
