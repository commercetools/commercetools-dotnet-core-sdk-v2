using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomObjects
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomObjects.CustomObjectDraft))]
    public partial interface ICustomObjectDraft
    {
        string Container { get; set; }

        string Key { get; set; }

        Object Value { get; set; }

        long? Version { get; set; }
    }
}
