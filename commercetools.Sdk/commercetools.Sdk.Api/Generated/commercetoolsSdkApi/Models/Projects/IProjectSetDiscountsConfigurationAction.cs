using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetDiscountsConfigurationAction))]
    public partial interface IProjectSetDiscountsConfigurationAction : IProjectUpdateAction
    {
        IDiscountsConfiguration DiscountsConfiguration { get; set; }

    }
}
