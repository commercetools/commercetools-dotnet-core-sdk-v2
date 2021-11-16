using commercetools.HistoryApi.Models.Common;
using System;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class CustomFieldExpandedValue : ICustomFieldExpandedValue
    {
        public string Name { get; set; }

        public Object Value { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
