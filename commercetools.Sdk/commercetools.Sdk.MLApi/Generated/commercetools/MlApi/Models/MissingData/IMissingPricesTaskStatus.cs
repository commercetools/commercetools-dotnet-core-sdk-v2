using commercetools.MLApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingPricesTaskStatus))]
    public partial interface IMissingPricesTaskStatus 
    {
        ITaskStatusEnum State { get; set;}
        
        DateTime Expires { get; set;}
        
        IMissingPricesPagedQueryResult Result { get; set;}
    }
}
