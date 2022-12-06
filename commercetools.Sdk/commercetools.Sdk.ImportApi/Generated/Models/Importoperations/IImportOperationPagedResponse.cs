using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importoperations
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importoperations.ImportOperationPagedResponse))]
    public partial interface IImportOperationPagedResponse
    {
        int Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long Total { get; set; }

        IList<IImportOperation> Results { get; set; }
        IEnumerable<IImportOperation> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
