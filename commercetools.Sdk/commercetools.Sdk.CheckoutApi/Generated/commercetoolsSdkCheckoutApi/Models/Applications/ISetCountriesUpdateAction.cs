using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.SetCountriesUpdateAction))]
    public partial interface ISetCountriesUpdateAction : IApplicationUpdateAction
    {
        new string Action { get; set; }

        IList<string> Countries { get; set; }

        IEnumerable<string> CountriesEnumerable { set => Countries = value.ToList(); }

    }
}
