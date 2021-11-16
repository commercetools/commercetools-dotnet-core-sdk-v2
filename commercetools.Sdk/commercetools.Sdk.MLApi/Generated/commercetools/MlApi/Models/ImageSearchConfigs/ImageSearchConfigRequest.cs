using commercetools.MLApi.Models.ImageSearchConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.ImageSearchConfigs
{
    public partial class ImageSearchConfigRequest : IImageSearchConfigRequest
    {
        public List<IImageSearchConfigUpdateAction> Actions { get; set;}
    }
}
