namespace commercetools.Api.Models
{
    public interface IResourceUpdateAction<out TAction> where TAction : IResourceUpdateAction<TAction>
    {
        public string Action { get; set; }

        TAction Get()
        {
            return (TAction)this;
        }
    }
}