using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class ItemState : IItemState
    {
        public double Quantity { get; set; }

        public IStateKeyReference State { get; set; }
    }
}
