// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantSetKeyActionQueryBuilderDsl
    {
        public VariantSetKeyActionQueryBuilderDsl()
        {
        }

        public static VariantSetKeyActionQueryBuilderDsl Of()
        {
            return new VariantSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantSetKeyActionQueryBuilderDsl>(p, VariantSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<VariantSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<VariantSetKeyActionQueryBuilderDsl>(p, VariantSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
