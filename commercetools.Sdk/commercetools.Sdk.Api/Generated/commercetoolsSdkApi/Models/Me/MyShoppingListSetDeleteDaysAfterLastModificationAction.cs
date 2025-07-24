

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListSetDeleteDaysAfterLastModificationAction : IMyShoppingListSetDeleteDaysAfterLastModificationAction
    {
        public string Action { get; set; }

        public int? DeleteDaysAfterLastModification { get; set; }
        public MyShoppingListSetDeleteDaysAfterLastModificationAction()
        {
            this.Action = "setDeleteDaysAfterLastModification";
        }
    }
}
