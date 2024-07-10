using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Types
{

    public partial class FieldDefinition : IFieldDefinition
    {
        public IFieldType Type { get; set; }

        public string Name { get; set; }

        public ILocalizedString Label { get; set; }

        public bool Required { get; set; }

        public ITypeTextInputHint InputHint { get; set; }
    }
}
