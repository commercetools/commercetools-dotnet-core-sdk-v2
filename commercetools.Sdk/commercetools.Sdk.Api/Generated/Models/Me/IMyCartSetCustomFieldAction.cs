using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetCustomFieldAction))]
    public partial interface IMyCartSetCustomFieldAction : IMyCartUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
