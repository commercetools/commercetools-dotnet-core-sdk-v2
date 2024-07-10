using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Image : IImage
    {
        public string Url { get; set; }

        public IImageDimensions Dimensions { get; set; }

        public string Label { get; set; }
    }
}
