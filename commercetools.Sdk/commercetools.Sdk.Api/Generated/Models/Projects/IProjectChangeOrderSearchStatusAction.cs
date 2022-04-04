using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeOrderSearchStatusAction))]
    public partial interface IProjectChangeOrderSearchStatusAction : IProjectUpdateAction
    {
        IOrderSearchStatus Status { get; set; }
    }
}
