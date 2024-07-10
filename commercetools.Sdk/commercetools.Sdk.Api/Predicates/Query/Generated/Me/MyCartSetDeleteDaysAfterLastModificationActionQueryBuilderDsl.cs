using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl
    {
        public MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl()
        {
        }

        public static MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl Of()
        {
            return new MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl>(p, MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, long> DeleteDaysAfterLastModification()
        {
            return new ComparisonPredicateBuilder<MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterLastModification")),
            p => new CombinationQueryPredicate<MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl>(p, MyCartSetDeleteDaysAfterLastModificationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
