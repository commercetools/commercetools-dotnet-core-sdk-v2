using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeOrderSearchStatusAction))]
    public partial interface IProjectChangeOrderSearchStatusAction : IProjectUpdateAction
    {
        IOrderSearchStatus Status { get; set; }
    }
}
