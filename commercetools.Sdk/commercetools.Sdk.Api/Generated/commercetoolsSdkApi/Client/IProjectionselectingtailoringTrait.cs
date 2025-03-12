using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IProjectionselectingtailoringTrait<T> where T : IProjectionselectingtailoringTrait<T>
    {
        List<string> GetStaged();

        /**
         * set staged with the specificied value
         */
        T WithStaged(bool staged);


        IProjectionselectingtailoringTrait<T> AsProjectionselectingtailoringTrait()
        {
            return this;
        }

        T AsProjectionselectingtailoringTraitToBaseType()
        {
            return (T)this;
        }
    }
}
