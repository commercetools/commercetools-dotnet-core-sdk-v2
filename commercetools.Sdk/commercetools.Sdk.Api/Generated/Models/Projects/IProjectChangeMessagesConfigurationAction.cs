using commercetools.Api.Models.Messages;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeMessagesConfigurationAction))]
    public partial interface IProjectChangeMessagesConfigurationAction : IProjectUpdateAction
    {
        IMessageConfigurationDraft MessagesConfiguration { get; set;}
    }
}
