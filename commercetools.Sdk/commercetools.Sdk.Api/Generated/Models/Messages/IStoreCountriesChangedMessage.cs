using commercetools.Sdk.Api.Models.StoreCountries;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreCountriesChangedMessage))]
    public partial interface IStoreCountriesChangedMessage : IMessage
    {
        IList<IStoreCountry> AddedCountries { get; set; }
        IEnumerable<IStoreCountry> AddedCountriesEnumerable { set => AddedCountries = value.ToList(); }


        IList<IStoreCountry> RemovedCountries { get; set; }
        IEnumerable<IStoreCountry> RemovedCountriesEnumerable { set => RemovedCountries = value.ToList(); }


    }
}
