using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetLanguagesAction))]
    public partial interface IStoreSetLanguagesAction : IStoreUpdateAction
    {
        IList<string> Languages { get; set; }
        IEnumerable<string> LanguagesEnumerable { set => Languages = value.ToList(); }


    }
}
