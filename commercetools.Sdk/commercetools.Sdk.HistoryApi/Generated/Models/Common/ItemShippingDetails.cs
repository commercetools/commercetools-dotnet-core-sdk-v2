using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ItemShippingDetails : IItemShippingDetails
    {
        public IList<IItemShippingTarget> Targets { get; set; }
        public IEnumerable<IItemShippingTarget> TargetsEnumerable { set => Targets = value.ToList(); }


        public bool Valid { get; set; }
    }
}
