using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.ImageSearchConfigs
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("changeStatus", typeof(commercetools.Ml.Models.ImageSearchConfigs.ChangeStatusUpdateAction))]
    public partial interface IImageSearchConfigUpdateAction 
    {
        string Action { get; set;}
    }
}
