using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeUpdate))]
    public partial interface ITypeUpdate
    {
        long Version { get; set; }

        List<ITypeUpdateAction> Actions { get; set; }
    }
}
