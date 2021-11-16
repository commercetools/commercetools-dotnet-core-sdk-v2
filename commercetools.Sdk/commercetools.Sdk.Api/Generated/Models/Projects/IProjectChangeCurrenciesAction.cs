using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ProjectChangeCurrenciesAction))]
    public partial interface IProjectChangeCurrenciesAction : IProjectUpdateAction
    {
        List<string> Currencies { get; set; }
    }
}
