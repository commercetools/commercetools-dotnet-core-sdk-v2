using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface IQueryTrait<T> where T : IQueryTrait<T>
    {
        List<string> GetWhere();

        /**
         * set where with the specificied value
         */
        T WithWhere(string where);

        /**
         * set predicateVar with the specificied value
         */
        T WithPredicateVar(string varName, string predicateVar);

        IQueryTrait<T> AsQueryTrait()
        {
            return this;
        }

        T AsQueryTraitToBaseType()
        {
            return (T)this;
        }
    }
}
