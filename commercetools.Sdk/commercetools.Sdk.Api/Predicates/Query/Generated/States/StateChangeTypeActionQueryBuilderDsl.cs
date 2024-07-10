using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateChangeTypeActionQueryBuilderDsl
    {
        public StateChangeTypeActionQueryBuilderDsl()
        {
        }

        public static StateChangeTypeActionQueryBuilderDsl Of()
        {
            return new StateChangeTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateChangeTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StateChangeTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StateChangeTypeActionQueryBuilderDsl>(p, StateChangeTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StateChangeTypeActionQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StateChangeTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StateChangeTypeActionQueryBuilderDsl>(p, StateChangeTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
