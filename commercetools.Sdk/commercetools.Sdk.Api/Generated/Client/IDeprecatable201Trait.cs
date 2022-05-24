namespace commercetools.Sdk.Api.Client
{
    public interface IDeprecatable201Trait<T> where T : IDeprecatable201Trait<T>
    {



        IDeprecatable201Trait<T> AsDeprecatable201Trait()
        {
            return this;
        }

        T AsDeprecatable201TraitToBaseType()
        {
            return (T)this;
        }
    }
}
