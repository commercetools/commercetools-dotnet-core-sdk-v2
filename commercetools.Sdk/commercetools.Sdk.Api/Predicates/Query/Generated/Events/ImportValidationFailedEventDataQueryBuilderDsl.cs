// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class ImportValidationFailedEventDataQueryBuilderDsl
    {
        public ImportValidationFailedEventDataQueryBuilderDsl()
        {
        }

        public static ImportValidationFailedEventDataQueryBuilderDsl Of()
        {
            return new ImportValidationFailedEventDataQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImportValidationFailedEventDataQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ImportValidationFailedEventDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ImportValidationFailedEventDataQueryBuilderDsl>(p, ImportValidationFailedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportValidationFailedEventDataQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ImportValidationFailedEventDataQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ImportValidationFailedEventDataQueryBuilderDsl>(p, ImportValidationFailedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportValidationFailedEventDataQueryBuilderDsl, string> ImportContainerKey()
        {
            return new ComparisonPredicateBuilder<ImportValidationFailedEventDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("importContainerKey")),
            p => new CombinationQueryPredicate<ImportValidationFailedEventDataQueryBuilderDsl>(p, ImportValidationFailedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
