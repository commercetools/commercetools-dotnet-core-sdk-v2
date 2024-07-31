using commercetools.Sdk.HistoryApi.Models.Common;
using System;

namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class CustomFieldExpandedValue : ICustomFieldExpandedValue
    {
        public string Name { get; set; }

        public Object Value { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
