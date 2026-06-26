// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantResourceIdentifierQueryBuilderDsl
    {
        public VariantResourceIdentifierQueryBuilderDsl()
        {
        }

        public static VariantResourceIdentifierQueryBuilderDsl Of()
        {
            return new VariantResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<VariantResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<VariantResourceIdentifierQueryBuilderDsl>(p, VariantResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantResourceIdentifierQueryBuilderDsl>(p, VariantResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<VariantResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<VariantResourceIdentifierQueryBuilderDsl>(p, VariantResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
