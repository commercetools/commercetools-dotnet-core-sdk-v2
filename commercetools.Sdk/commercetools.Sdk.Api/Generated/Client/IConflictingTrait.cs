// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IConflictingTrait<T> where T : IConflictingTrait<T>
    {



        IConflictingTrait<T> AsConflictingTrait()
        {
            return this;
        }

        T AsConflictingTraitToBaseType()
        {
            return (T)this;
        }
    }
}
