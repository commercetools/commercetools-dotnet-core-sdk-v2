using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetDeleteDaysAfterLastModificationAction))]
    public partial interface IMyCartSetDeleteDaysAfterLastModificationAction : IMyCartUpdateAction
    {
        int? DeleteDaysAfterLastModification { get; set;}
    }
}
