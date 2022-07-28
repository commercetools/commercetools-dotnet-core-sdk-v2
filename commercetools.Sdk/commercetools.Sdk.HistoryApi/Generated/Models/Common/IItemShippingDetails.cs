using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ItemShippingDetails))]
    public partial interface IItemShippingDetails
    {
        List<IItemShippingTarget> Targets { get; set; }

        bool Valid { get; set; }

    }
}
