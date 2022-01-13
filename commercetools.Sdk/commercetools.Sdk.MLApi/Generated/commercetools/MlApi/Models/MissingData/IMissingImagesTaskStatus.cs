using commercetools.MLApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingImagesTaskStatus))]
    public partial interface IMissingImagesTaskStatus
    {
        ITaskStatusEnum State { get; set; }

        DateTime Expires { get; set; }

        IMissingImagesPagedQueryResult Result { get; set; }
    }
}
