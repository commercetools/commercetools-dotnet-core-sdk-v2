using System.Collections.Generic;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditUpdate : IOrderEditUpdate
    {
        public long Version { get; set; }

        public List<IOrderEditUpdateAction> Actions { get; set; }

        public bool? DryRun { get; set; }
    }
}
