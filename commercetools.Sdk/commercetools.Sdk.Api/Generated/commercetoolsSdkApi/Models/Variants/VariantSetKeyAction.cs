

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantSetKeyAction : IVariantSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public VariantSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
