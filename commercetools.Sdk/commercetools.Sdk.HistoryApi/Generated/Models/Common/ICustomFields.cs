using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CustomFields))]
    public partial interface ICustomFields
    {
        IReference Type { get; set; }

        Object Fields { get; set; }
    }
}
