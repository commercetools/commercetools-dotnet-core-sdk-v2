using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ShoppingListsConfigurationQueryBuilderDsl
    {
        public ShoppingListsConfigurationQueryBuilderDsl()
        {
        }

        public static ShoppingListsConfigurationQueryBuilderDsl Of()
        {
            return new ShoppingListsConfigurationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListsConfigurationQueryBuilderDsl, long> DeleteDaysAfterLastModification()
        {
            return new ComparisonPredicateBuilder<ShoppingListsConfigurationQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterLastModification")),
            p => new CombinationQueryPredicate<ShoppingListsConfigurationQueryBuilderDsl>(p, ShoppingListsConfigurationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
