using commercetools.Api.Models.Common;
using System;


namespace commercetools.Api.Models.Errors
{
    public partial class DuplicateFieldWithConflictingResourceError : IDuplicateFieldWithConflictingResourceError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string Field { get; set; }

        public Object DuplicateValue { get; set; }

        public IReference ConflictingResource { get; set; }
        public DuplicateFieldWithConflictingResourceError()
        {
            this.Code = "DuplicateFieldWithConflictingResource";
        }
    }
}
