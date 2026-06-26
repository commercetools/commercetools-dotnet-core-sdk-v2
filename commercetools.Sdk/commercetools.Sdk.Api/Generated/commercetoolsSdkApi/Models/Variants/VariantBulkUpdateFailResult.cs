using commercetools.Sdk.Api.Models.Errors;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantBulkUpdateFailResult : IVariantBulkUpdateFailResult
    {
        public string Id { get; set; }

        public string Key { get; set; }

        public string Status { get; set; }

        public IList<IErrorObject> Errors { get; set; }

        public IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }
        public VariantBulkUpdateFailResult()
        {
            this.Status = "Fail";
        }
    }
}
