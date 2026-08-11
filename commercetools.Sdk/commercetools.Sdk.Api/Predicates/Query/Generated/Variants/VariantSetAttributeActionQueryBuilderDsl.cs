// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantSetAttributeActionQueryBuilderDsl
    {
        public VariantSetAttributeActionQueryBuilderDsl()
        {
        }

        public static VariantSetAttributeActionQueryBuilderDsl Of()
        {
            return new VariantSetAttributeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSetAttributeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantSetAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantSetAttributeActionQueryBuilderDsl>(p, VariantSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAttributeActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<VariantSetAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<VariantSetAttributeActionQueryBuilderDsl>(p, VariantSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAttributeActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<VariantSetAttributeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<VariantSetAttributeActionQueryBuilderDsl>(p, VariantSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantSetAttributeActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSetAttributeActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSetAttributeActionQueryBuilderDsl>(p, VariantSetAttributeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
