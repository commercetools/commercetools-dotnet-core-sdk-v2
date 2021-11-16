using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Types
{
    public partial class TypeChangeNameAction : ITypeChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public TypeChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
