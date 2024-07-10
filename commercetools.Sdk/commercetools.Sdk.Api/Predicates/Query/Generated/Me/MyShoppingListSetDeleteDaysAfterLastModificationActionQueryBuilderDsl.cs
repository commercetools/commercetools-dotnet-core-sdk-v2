using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl
    {
        public MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl Of()
        {
            return new MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl>(p, MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, long> DeleteDaysAfterLastModification()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterLastModification")),
            p => new CombinationQueryPredicate<MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl>(p, MyShoppingListSetDeleteDaysAfterLastModificationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
