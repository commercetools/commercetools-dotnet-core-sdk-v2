using System;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingImagesMeta : IMissingImagesMeta
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        public IMissingImagesProductLevel ProductLevel { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public IMissingImagesVariantLevel VariantLevel { get; set; }

        public long Threshold { get; set; }
    }
}
