namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionSetKeyAction : IExtensionSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public ExtensionSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
