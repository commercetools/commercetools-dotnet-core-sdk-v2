using commercetools.Sdk.Api.Models.Messages;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeMessagesConfigurationAction : IProjectChangeMessagesConfigurationAction
    {
        public string Action { get; set; }

        public IMessagesConfigurationDraft MessagesConfiguration { get; set; }
        public ProjectChangeMessagesConfigurationAction()
        {
            this.Action = "changeMessagesConfiguration";
        }
    }
}
