using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Types
{
    public partial class TypeSetDescriptionAction : ITypeSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public TypeSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
