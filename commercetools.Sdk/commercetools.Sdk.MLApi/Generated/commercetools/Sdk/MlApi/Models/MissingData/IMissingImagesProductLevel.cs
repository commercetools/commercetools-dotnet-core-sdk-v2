using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingImagesProductLevel))]
    [Obsolete]
    public partial interface IMissingImagesProductLevel : IMissingImagesCount
    {
        new long MissingImages { get; set; }

        new long Total { get; set; }

    }
}
