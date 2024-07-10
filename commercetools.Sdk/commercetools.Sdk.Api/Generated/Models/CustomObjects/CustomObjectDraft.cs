using System;


namespace commercetools.Sdk.Api.Models.CustomObjects
{

    public partial class CustomObjectDraft : ICustomObjectDraft
    {
        public string Container { get; set; }

        public string Key { get; set; }

        public Object Value { get; set; }

        public long? Version { get; set; }
    }
}
