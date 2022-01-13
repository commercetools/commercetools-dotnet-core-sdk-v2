using commercetools.Api.Models.Messages;


namespace commercetools.Api.Models.Projects
{
    public partial class ProjectChangeMessagesConfigurationAction : IProjectChangeMessagesConfigurationAction
    {
        public string Action { get; set; }

        public IMessageConfigurationDraft MessagesConfiguration { get; set; }
        public ProjectChangeMessagesConfigurationAction()
        {
            this.Action = "changeMessagesConfiguration";
        }
    }
}
