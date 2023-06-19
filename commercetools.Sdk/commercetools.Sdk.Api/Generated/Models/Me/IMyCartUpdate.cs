using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartUpdate))]
    public partial interface IMyCartUpdate
    {
        long Version { get; set; }

        IList<IMyCartUpdateAction> Actions { get; set; }
        IEnumerable<IMyCartUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
