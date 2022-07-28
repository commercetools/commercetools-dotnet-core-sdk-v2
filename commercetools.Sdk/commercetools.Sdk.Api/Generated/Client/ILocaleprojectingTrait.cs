using System.Collections.Generic;

namespace commercetools.Sdk.Api.Client
{
    public interface ILocaleprojectingTrait<T> where T : ILocaleprojectingTrait<T>
    {
        List<string> GetLocaleProjection();

        /**
         * set localeProjection with the specificied value
         */
        T WithLocaleProjection(string localeProjection);


        ILocaleprojectingTrait<T> AsLocaleprojectingTrait()
        {
            return this;
        }

        T AsLocaleprojectingTraitToBaseType()
        {
            return (T)this;
        }
    }
}
