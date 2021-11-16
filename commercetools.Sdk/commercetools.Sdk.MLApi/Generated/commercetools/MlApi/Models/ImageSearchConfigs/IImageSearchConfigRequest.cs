using commercetools.MLApi.Models.ImageSearchConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.ImageSearchConfigs
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.ImageSearchConfigs.ImageSearchConfigRequest))]
    public partial interface IImageSearchConfigRequest 
    {
        List<IImageSearchConfigUpdateAction> Actions { get; set;}
    }
}
