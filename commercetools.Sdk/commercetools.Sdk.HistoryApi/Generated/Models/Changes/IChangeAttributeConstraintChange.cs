using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAttributeConstraintChange))]
    public partial interface IChangeAttributeConstraintChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string AttributeName { get; set; }

        IAttributeConstraintEnum PreviousValue { get; set; }

        IAttributeConstraintEnum NextValue { get; set; }

    }
}
