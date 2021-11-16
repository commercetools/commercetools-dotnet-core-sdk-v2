using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartUpdate))]
    public partial interface IMyCartUpdate 
    {
        long Version { get; set;}
        
        List<IMyCartUpdateAction> Actions { get; set;}
    }
}
