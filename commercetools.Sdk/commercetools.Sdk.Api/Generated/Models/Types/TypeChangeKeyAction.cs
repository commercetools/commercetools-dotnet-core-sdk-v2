namespace commercetools.Api.Models.Types
{
    public partial class TypeChangeKeyAction : ITypeChangeKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public TypeChangeKeyAction()
        {
            this.Action = "changeKey";
        }
    }
}
