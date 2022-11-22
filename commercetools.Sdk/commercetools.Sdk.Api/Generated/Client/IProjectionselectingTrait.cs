using System.Collections.Generic;

namespace commercetools.Sdk.Api.Client
{
    public interface IProjectionselectingTrait<T> where T : IProjectionselectingTrait<T>
    {
        List<string> GetStaged();

        /**
         * set staged with the specificied value
         */
        T WithStaged(bool staged);


        IProjectionselectingTrait<T> AsProjectionselectingTrait()
        {
            return this;
        }

        T AsProjectionselectingTraitToBaseType()
        {
            return (T)this;
        }
    }
}
