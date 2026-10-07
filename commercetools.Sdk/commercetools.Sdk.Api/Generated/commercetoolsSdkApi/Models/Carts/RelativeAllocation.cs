

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class RelativeAllocation : IRelativeAllocation
    {
        public string Type { get; set; }

        public int Percentage { get; set; }
        public RelativeAllocation()
        {
            this.Type = "Relative";
        }
    }
}
