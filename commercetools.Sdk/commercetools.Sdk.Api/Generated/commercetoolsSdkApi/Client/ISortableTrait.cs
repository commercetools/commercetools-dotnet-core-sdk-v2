using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface ISortableTrait<T> where T : ISortableTrait<T>
    {
        List<string> GetSort();

        /**
         * set sort with the specificied value
         */
        T WithSort(string sort);


        ISortableTrait<T> AsSortableTrait()
        {
            return this;
        }

        T AsSortableTraitToBaseType()
        {
            return (T)this;
        }
    }
}
