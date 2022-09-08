using commercetools.Sdk.MLApi.Models.Common;
using System;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingDataTaskStatus : IMissingDataTaskStatus
    {
        public ITaskStatusEnum State { get; set; }

        public DateTime Expires { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public IMissingAttributesPagedQueryResult Result { get; set; }
    }
}
