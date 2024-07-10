using commercetools.Sdk.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditApplied : IOrderEditApplied
    {
        public string Type { get; set; }

        public DateTime AppliedAt { get; set; }

        public IOrderExcerpt ExcerptBeforeEdit { get; set; }

        public IOrderExcerpt ExcerptAfterEdit { get; set; }
        public OrderEditApplied()
        {
            this.Type = "Applied";
        }
    }
}
