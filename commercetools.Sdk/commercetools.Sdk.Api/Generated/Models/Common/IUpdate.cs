using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.Update))]
    public partial interface IUpdate 
    {
        long Version { get; set;}
        
        List<IUpdateAction> Actions { get; set;}
    }
}
