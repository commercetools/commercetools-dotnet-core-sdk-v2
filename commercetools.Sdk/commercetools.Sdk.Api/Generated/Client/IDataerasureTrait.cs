using System.Collections.Generic;

namespace commercetools.Sdk.Api.Client
{
    public interface IDataerasureTrait<T> where T : IDataerasureTrait<T>
    {
        List<string> GetDataErasure();

        /**
         * set dataErasure with the specificied value
         */
        T WithDataErasure(bool dataErasure);


        IDataerasureTrait<T> AsDataerasureTrait()
        {
            return this;
        }

        T AsDataerasureTraitToBaseType()
        {
            return (T)this;
        }
    }
}
