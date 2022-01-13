using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeMessagesEnabledAction))]
    public partial interface IProjectChangeMessagesEnabledAction : IProjectUpdateAction
    {
        bool MessagesEnabled { get; set; }
    }
}
