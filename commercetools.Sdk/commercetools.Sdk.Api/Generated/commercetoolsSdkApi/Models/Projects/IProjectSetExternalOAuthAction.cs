using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetExternalOAuthAction))]
    public partial interface IProjectSetExternalOAuthAction : IProjectUpdateAction
    {
        IExternalOAuth ExternalOAuth { get; set; }

    }
}
