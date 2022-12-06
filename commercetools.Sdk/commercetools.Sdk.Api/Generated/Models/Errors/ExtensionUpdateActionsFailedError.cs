using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ExtensionUpdateActionsFailedError : IExtensionUpdateActionsFailedError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public ILocalizedString LocalizedMessage { get; set; }

        public Object ExtensionExtraInfo { get; set; }

        public List<IExtensionError> ExtensionErrors { get; set; }
        public ExtensionUpdateActionsFailedError()
        {
            this.Code = "ExtensionUpdateActionsFailed";
        }
    }
}
