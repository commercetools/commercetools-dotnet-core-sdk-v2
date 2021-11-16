using commercetools.MLApi.Models.Common;
using System;


namespace commercetools.MLApi.Models.MissingData
{
    public partial class MissingImagesTaskStatus : IMissingImagesTaskStatus
    {
        public ITaskStatusEnum State { get; set; }

        public DateTime Expires { get; set; }

        public IMissingImagesPagedQueryResult Result { get; set; }
    }
}
