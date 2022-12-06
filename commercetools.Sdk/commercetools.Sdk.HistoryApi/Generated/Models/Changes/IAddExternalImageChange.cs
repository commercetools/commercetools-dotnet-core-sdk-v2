using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddExternalImageChange))]
    public partial interface IAddExternalImageChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string CatalogData { get; set; }

        IList<IImage> PreviousValue { get; set; }
        IEnumerable<IImage> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IImage> NextValue { get; set; }
        IEnumerable<IImage> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
