using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IExpandableTrait<T> where T : IExpandableTrait<T>
    {
        List<string> GetExpand();

        /**
         * set expand with the specificied value
         */
        T WithExpand(string expand);


        IExpandableTrait<T> AsExpandableTrait()
        {
            return this;
        }

        T AsExpandableTraitToBaseType()
        {
            return (T)this;
        }
    }
}
