using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.CustomFields))]
    public partial interface ICustomFields 
    {
        IReference Type { get; set;}
        
        Object Fields { get; set;}
    }
}
