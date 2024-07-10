using commercetools.Sdk.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeUpdate : IDiscountCodeUpdate
    {
        public long Version { get; set; }

        public IList<IDiscountCodeUpdateAction> Actions { get; set; }
        public IEnumerable<IDiscountCodeUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
