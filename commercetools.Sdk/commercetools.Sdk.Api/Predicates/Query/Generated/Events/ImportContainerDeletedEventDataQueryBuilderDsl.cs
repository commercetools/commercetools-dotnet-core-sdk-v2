// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class ImportContainerDeletedEventDataQueryBuilderDsl
    {
        public ImportContainerDeletedEventDataQueryBuilderDsl()
        {
        }

        public static ImportContainerDeletedEventDataQueryBuilderDsl Of()
        {
            return new ImportContainerDeletedEventDataQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImportContainerDeletedEventDataQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ImportContainerDeletedEventDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ImportContainerDeletedEventDataQueryBuilderDsl>(p, ImportContainerDeletedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportContainerDeletedEventDataQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ImportContainerDeletedEventDataQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ImportContainerDeletedEventDataQueryBuilderDsl>(p, ImportContainerDeletedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
