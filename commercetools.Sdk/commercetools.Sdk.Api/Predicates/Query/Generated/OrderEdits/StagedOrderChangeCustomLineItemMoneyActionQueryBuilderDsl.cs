using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl
    {
        public StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl()
        {
        }

        public static StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl Of()
        {
            return new StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl>(p, StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl>(p, StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl> Money(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("money"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                StagedOrderChangeCustomLineItemMoneyActionQueryBuilderDsl.Of);
        }


    }
}
