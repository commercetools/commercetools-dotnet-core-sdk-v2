using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.ImageSearchConfigs
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("changeStatus", typeof(commercetools.MLApi.Models.ImageSearchConfigs.ChangeStatusUpdateAction))]
    public partial interface IImageSearchConfigUpdateAction 
    {
        string Action { get; set;}
    }
}
