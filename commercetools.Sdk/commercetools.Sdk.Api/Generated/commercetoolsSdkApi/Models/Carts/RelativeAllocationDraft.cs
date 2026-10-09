

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class RelativeAllocationDraft : IRelativeAllocationDraft
    {
        public string Type { get; set; }

        public int Percentage { get; set; }
        public RelativeAllocationDraft()
        {
            this.Type = "Relative";
        }
    }
}
