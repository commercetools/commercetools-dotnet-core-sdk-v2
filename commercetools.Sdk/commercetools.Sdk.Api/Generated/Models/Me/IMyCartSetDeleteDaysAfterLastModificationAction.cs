using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetDeleteDaysAfterLastModificationAction))]
    public partial interface IMyCartSetDeleteDaysAfterLastModificationAction : IMyCartUpdateAction
    {
        int? DeleteDaysAfterLastModification { get; set; }

    }
}
