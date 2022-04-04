using System;


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
