using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitUpdate))]
    public partial interface IMyBusinessUnitUpdate
    {
        long Version { get; set; }

        IList<IMyBusinessUnitUpdateAction> Actions { get; set; }

        IEnumerable<IMyBusinessUnitUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
