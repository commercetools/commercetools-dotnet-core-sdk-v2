using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Common
{
    public interface IImage 
    {
        string Url { get; set;}
        
        IImageDimensions Dimensions { get; set;}
        
        string Label { get; set;}
    }
}
