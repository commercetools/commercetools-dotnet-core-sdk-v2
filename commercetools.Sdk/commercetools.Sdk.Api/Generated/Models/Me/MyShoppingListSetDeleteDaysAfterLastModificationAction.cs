namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListSetDeleteDaysAfterLastModificationAction : IMyShoppingListSetDeleteDaysAfterLastModificationAction
    {
        public string Action { get; set;}
        
        public long? DeleteDaysAfterLastModification { get; set;}
        public MyShoppingListSetDeleteDaysAfterLastModificationAction()
        { 
           this.Action = "setDeleteDaysAfterLastModification";
        }
    }
}
