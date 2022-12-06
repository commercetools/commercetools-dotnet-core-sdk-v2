using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeUpdate))]
    public partial interface ITypeUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ITypeUpdate, ITypeUpdateAction>
    {
        new long Version { get; set; }
        new IList<ITypeUpdateAction> Actions { get; set; }
        IEnumerable<ITypeUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
