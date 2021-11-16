using System.Collections.Generic;


namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionChangeTriggersAction : IExtensionChangeTriggersAction
    {
        public string Action { get; set; }

        public List<IExtensionTrigger> Triggers { get; set; }
        public ExtensionChangeTriggersAction()
        {
            this.Action = "changeTriggers";
        }
    }
}
