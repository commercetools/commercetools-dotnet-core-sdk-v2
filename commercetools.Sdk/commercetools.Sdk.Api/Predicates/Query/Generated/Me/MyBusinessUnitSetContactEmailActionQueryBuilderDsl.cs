using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitSetContactEmailActionQueryBuilderDsl
    {
        public MyBusinessUnitSetContactEmailActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitSetContactEmailActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitSetContactEmailActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitSetContactEmailActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetContactEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetContactEmailActionQueryBuilderDsl>(p, MyBusinessUnitSetContactEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitSetContactEmailActionQueryBuilderDsl, string> ContactEmail()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitSetContactEmailActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactEmail")),
            p => new CombinationQueryPredicate<MyBusinessUnitSetContactEmailActionQueryBuilderDsl>(p, MyBusinessUnitSetContactEmailActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
