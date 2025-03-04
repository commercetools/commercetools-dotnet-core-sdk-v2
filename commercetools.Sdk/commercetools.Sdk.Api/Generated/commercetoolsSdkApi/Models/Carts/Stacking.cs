

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class Stacking : IStacking
    {
        public string Type { get; set; }
        public Stacking()
        {
            this.Type = "Stacking";
        }
    }
}
