using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateSetNameActionQueryBuilderDsl
    {
        public StateSetNameActionQueryBuilderDsl()
        {
        }

        public static StateSetNameActionQueryBuilderDsl Of()
        {
            return new StateSetNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateSetNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StateSetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StateSetNameActionQueryBuilderDsl>(p, StateSetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StateSetNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateSetNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                StateSetNameActionQueryBuilderDsl.Of);
        }


    }
}
