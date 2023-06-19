using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    [Obsolete]
    public partial class IndividualProductSelectionTypeQueryBuilderDsl
    {
        public IndividualProductSelectionTypeQueryBuilderDsl()
        {
        }

        public static IndividualProductSelectionTypeQueryBuilderDsl Of()
        {
            return new IndividualProductSelectionTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<IndividualProductSelectionTypeQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<IndividualProductSelectionTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<IndividualProductSelectionTypeQueryBuilderDsl>(p, IndividualProductSelectionTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<IndividualProductSelectionTypeQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<IndividualProductSelectionTypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                IndividualProductSelectionTypeQueryBuilderDsl.Of);
        }


    }
}
