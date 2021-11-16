using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.ItemShippingDetails))]
    public partial interface IItemShippingDetails
    {
        List<IItemShippingTarget> Targets { get; set; }

        bool Valid { get; set; }
    }
}
