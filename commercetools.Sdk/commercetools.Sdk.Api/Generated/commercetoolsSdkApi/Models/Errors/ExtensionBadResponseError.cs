using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ExtensionBadResponseError : IExtensionBadResponseError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public ILocalizedString LocalizedMessage { get; set; }

        public Object ExtensionExtraInfo { get; set; }

        public IList<IExtensionError> ExtensionErrors { get; set; }
        public IEnumerable<IExtensionError> ExtensionErrorsEnumerable { set => ExtensionErrors = value.ToList(); }


        public string ExtensionBody { get; set; }

        public int? ExtensionStatusCode { get; set; }

        public string ExtensionId { get; set; }

        public string ExtensionKey { get; set; }
        public ExtensionBadResponseError()
        {
            this.Code = "ExtensionBadResponse";
        }
    }
}
