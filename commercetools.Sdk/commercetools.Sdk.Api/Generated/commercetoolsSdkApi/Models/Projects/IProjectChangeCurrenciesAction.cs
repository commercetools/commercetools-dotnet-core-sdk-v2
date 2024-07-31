using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectChangeCurrenciesAction))]
    public partial interface IProjectChangeCurrenciesAction : IProjectUpdateAction
    {
        IList<string> Currencies { get; set; }

        IEnumerable<string> CurrenciesEnumerable { set => Currencies = value.ToList(); }

    }
}
