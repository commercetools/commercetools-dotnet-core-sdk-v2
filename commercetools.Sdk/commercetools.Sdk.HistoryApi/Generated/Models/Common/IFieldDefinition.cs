using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.FieldDefinition))]
    public partial interface IFieldDefinition
    {
        Object Type { get; set; }

        string Name { get; set; }

        ILocalizedString Label { get; set; }

        ITextInputHint InputHint { get; set; }
    }
}
