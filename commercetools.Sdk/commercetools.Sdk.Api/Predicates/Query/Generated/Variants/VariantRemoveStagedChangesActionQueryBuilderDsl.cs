// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantRemoveStagedChangesActionQueryBuilderDsl
    {
        public VariantRemoveStagedChangesActionQueryBuilderDsl()
        {
        }

        public static VariantRemoveStagedChangesActionQueryBuilderDsl Of()
        {
            return new VariantRemoveStagedChangesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantRemoveStagedChangesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantRemoveStagedChangesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantRemoveStagedChangesActionQueryBuilderDsl>(p, VariantRemoveStagedChangesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
