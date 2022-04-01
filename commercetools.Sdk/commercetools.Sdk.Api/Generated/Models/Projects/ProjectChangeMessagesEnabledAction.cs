namespace commercetools.Sdk.Api.Models.Projects
{
    public partial class ProjectChangeMessagesEnabledAction : IProjectChangeMessagesEnabledAction
    {
        public string Action { get; set; }

        public bool MessagesEnabled { get; set; }
        public ProjectChangeMessagesEnabledAction()
        {
            this.Action = "changeMessagesEnabled";
        }
    }
}
