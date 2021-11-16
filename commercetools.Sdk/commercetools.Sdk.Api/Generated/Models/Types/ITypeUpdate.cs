using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeUpdate))]
    public partial interface ITypeUpdate
    {
        long Version { get; set; }

        List<ITypeUpdateAction> Actions { get; set; }
    }
}
