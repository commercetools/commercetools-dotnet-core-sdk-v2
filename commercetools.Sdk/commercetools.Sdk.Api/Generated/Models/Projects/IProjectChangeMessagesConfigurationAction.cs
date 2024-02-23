using commercetools.Sdk.Api.Models.Messages;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeMessagesConfigurationAction))]
    public partial interface IProjectChangeMessagesConfigurationAction : IProjectUpdateAction
    {
        IMessagesConfigurationDraft MessagesConfiguration { get; set; }

    }
}
