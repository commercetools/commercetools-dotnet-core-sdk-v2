using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
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
