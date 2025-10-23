using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.FieldContainer))]
    public partial interface IFieldContainer : IDictionary<string, Object>
    {
    }
}
