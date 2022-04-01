using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCurrenciesAction))]
    public partial interface IProjectChangeCurrenciesAction : IProjectUpdateAction
    {
        List<string> Currencies { get; set; }
    }
}
