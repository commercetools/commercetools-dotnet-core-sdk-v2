using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class InvalidFieldsUpdateError : IInvalidFieldsUpdateError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IList<string> Fields { get; set; }

        public IEnumerable<string> FieldsEnumerable { set => Fields = value.ToList(); }
        public InvalidFieldsUpdateError()
        {
            this.Code = "InvalidFieldUpdate";
        }
    }
}
