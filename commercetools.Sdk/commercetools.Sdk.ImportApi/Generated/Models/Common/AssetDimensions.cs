using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class AssetDimensions : IAssetDimensions
    {
        public int W { get; set; }

        public int H { get; set; }
    }
}
