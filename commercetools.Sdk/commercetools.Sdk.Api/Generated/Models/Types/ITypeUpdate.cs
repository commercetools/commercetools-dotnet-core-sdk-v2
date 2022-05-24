using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeUpdate))]
    public partial interface ITypeUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ITypeUpdate, ITypeUpdateAction>
    {
        new long Version { get; set; }
        new List<ITypeUpdateAction> Actions { get; set; }
    }
}
