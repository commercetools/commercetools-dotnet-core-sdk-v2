// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class DuplicateEnumValuesErrorQueryBuilderDsl
    {
        public DuplicateEnumValuesErrorQueryBuilderDsl()
        {
        }

        public static DuplicateEnumValuesErrorQueryBuilderDsl Of()
        {
            return new DuplicateEnumValuesErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DuplicateEnumValuesErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<DuplicateEnumValuesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<DuplicateEnumValuesErrorQueryBuilderDsl>(p, DuplicateEnumValuesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateEnumValuesErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<DuplicateEnumValuesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<DuplicateEnumValuesErrorQueryBuilderDsl>(p, DuplicateEnumValuesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<DuplicateEnumValuesErrorQueryBuilderDsl, string> Duplicates()
        {
            return new ComparableCollectionPredicateBuilder<DuplicateEnumValuesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("duplicates")),
            p => new CombinationQueryPredicate<DuplicateEnumValuesErrorQueryBuilderDsl>(p, DuplicateEnumValuesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
