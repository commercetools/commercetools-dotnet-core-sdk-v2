using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeUpdate))]
    public partial interface ITypeUpdate
    {
        long Version { get; set; }

        IList<ITypeUpdateAction> Actions { get; set; }
        IEnumerable<ITypeUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
