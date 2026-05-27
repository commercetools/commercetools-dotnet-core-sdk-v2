

namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionSetAdditionalContextAction : IExtensionSetAdditionalContextAction
    {
        public string Action { get; set; }

        public IExtensionAdditionalContextDraft AdditionalContext { get; set; }
        public ExtensionSetAdditionalContextAction()
        {
            this.Action = "setAdditionalContext";
        }
    }
}
