using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateChangeKeyActionQueryBuilderDsl
    {
        public StateChangeKeyActionQueryBuilderDsl()
        {
        }

        public static StateChangeKeyActionQueryBuilderDsl Of()
        {
            return new StateChangeKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateChangeKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StateChangeKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StateChangeKeyActionQueryBuilderDsl>(p, StateChangeKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StateChangeKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<StateChangeKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<StateChangeKeyActionQueryBuilderDsl>(p, StateChangeKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
