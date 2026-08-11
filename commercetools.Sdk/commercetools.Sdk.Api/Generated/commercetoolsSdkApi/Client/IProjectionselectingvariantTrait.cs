using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IProjectionselectingvariantTrait<T> where T : IProjectionselectingvariantTrait<T>
    {
        List<string> GetStaged();

        /**
         * set staged with the specificied value
         */
        T WithStaged(bool staged);


        IProjectionselectingvariantTrait<T> AsProjectionselectingvariantTrait()
        {
            return this;
        }

        T AsProjectionselectingvariantTraitToBaseType()
        {
            return (T)this;
        }
    }
}
