using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.AssociateRoleLabel))]
    public partial interface IAssociateRoleLabel : ILabel
    {
        new string Type { get; set; }

        string Key { get; set; }

        string Name { get; set; }

    }
}
