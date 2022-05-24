namespace commercetools.Sdk.Api.Client
{
    public interface IErrorableTrait<T> where T : IErrorableTrait<T>
    {



        IErrorableTrait<T> AsErrorableTrait()
        {
            return this;
        }

        T AsErrorableTraitToBaseType()
        {
            return (T)this;
        }
    }
}
