using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    [Obsolete]
    public partial class IndividualExclusionProductSelectionTypeQueryBuilderDsl
    {
        public IndividualExclusionProductSelectionTypeQueryBuilderDsl()
        {
        }

        public static IndividualExclusionProductSelectionTypeQueryBuilderDsl Of()
        {
            return new IndividualExclusionProductSelectionTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<IndividualExclusionProductSelectionTypeQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<IndividualExclusionProductSelectionTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<IndividualExclusionProductSelectionTypeQueryBuilderDsl>(p, IndividualExclusionProductSelectionTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<IndividualExclusionProductSelectionTypeQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<IndividualExclusionProductSelectionTypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                IndividualExclusionProductSelectionTypeQueryBuilderDsl.Of);
        }


    }
}
