using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionUpdate))]
    public partial interface IExtensionUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IExtensionUpdate, IExtensionUpdateAction>
    {
        new long Version { get; set; }
        new IList<IExtensionUpdateAction> Actions { get; set; }
        IEnumerable<IExtensionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
