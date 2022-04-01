namespace commercetools.Sdk.Api.Models.Types
{
    public partial class TypeChangeInputHintAction : ITypeChangeInputHintAction
    {
        public string Action { get; set; }

        public string FieldName { get; set; }

        public ITypeTextInputHint InputHint { get; set; }
        public TypeChangeInputHintAction()
        {
            this.Action = "changeInputHint";
        }
    }
}
