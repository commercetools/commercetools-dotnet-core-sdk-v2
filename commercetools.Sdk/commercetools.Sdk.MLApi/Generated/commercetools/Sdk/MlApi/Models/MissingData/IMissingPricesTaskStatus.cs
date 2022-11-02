using commercetools.Sdk.MLApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingPricesTaskStatus))]
    public partial interface IMissingPricesTaskStatus
    {
        ITaskStatusEnum State { get; set; }

        DateTime Expires { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingPricesPagedQueryResult Result { get; set; }

    }
}
