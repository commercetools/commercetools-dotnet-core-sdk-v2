using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetExternalOAuthAction))]
    public partial interface IProjectSetExternalOAuthAction : IProjectUpdateAction
    {
        IExternalOAuth ExternalOAuth { get; set; }

    }
}
