using commercetools.MLApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingDataTaskStatus))]
    public partial interface IMissingDataTaskStatus
    {
        ITaskStatusEnum State { get; set; }

        DateTime Expires { get; set; }

        IMissingAttributesPagedQueryResult Result { get; set; }
    }
}
