namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetDeleteDaysAfterLastModificationAction : ICartSetDeleteDaysAfterLastModificationAction
    {
        public string Action { get; set; }

        public int? DeleteDaysAfterLastModification { get; set; }
        public CartSetDeleteDaysAfterLastModificationAction()
        {
            this.Action = "setDeleteDaysAfterLastModification";
        }
    }
}
