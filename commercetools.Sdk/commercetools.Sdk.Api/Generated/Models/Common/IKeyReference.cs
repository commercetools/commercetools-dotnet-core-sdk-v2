using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [SubTypeDiscriminator("store", typeof(commercetools.Api.Models.Stores.StoreKeyReference))]
    public partial interface IKeyReference 
    {
        IReferenceTypeId TypeId { get; set;}
        
        string Key { get; set;}
    }
}
