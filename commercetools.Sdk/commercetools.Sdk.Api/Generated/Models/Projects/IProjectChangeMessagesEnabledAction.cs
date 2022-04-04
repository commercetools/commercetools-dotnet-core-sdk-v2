using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeMessagesEnabledAction))]
    public partial interface IProjectChangeMessagesEnabledAction : IProjectUpdateAction
    {
        bool MessagesEnabled { get; set; }
    }
}
