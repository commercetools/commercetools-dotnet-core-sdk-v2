using commercetools.Api.Models.Common;
using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.Extension))]
    public partial interface IExtension : IBaseResource
    {
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Key { get; set;}
        
        IExtensionDestination Destination { get; set;}
        
        List<IExtensionTrigger> Triggers { get; set;}
        
        int? TimeoutInMs { get; set;}
    }
}
