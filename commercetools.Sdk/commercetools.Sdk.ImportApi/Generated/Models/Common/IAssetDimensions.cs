using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Common.AssetDimensions))]
    public partial interface IAssetDimensions 
    {
        int W { get; set;}
        
        int H { get; set;}
    }
}
