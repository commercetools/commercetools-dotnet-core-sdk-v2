using commercetools.Sdk.Api.Models.StoreCountries;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetCountriesAction))]
    public partial interface IStoreSetCountriesAction : IStoreUpdateAction
    {
        IList<IStoreCountry> Countries { get; set; }
        IEnumerable<IStoreCountry> CountriesEnumerable { set => Countries = value.ToList(); }


    }
}
