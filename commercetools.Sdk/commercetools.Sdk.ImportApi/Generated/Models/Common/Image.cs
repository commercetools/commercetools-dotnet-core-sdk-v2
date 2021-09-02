using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    public partial class Image : IImage
    {
        public string Url { get; set; }

        public IAssetDimensions Dimensions { get; set; }

        public string Label { get; set; }
    }
}
