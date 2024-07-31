using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeProductSearchIndexingEnabledAction))]
    public partial interface IProjectChangeProductSearchIndexingEnabledAction : IProjectUpdateAction
    {
        bool Enabled { get; set; }

        IProductSearchIndexingMode Mode { get; set; }

    }
}
