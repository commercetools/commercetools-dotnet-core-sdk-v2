// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class ImportOperationRejectedEventDataQueryBuilderDsl
    {
        public ImportOperationRejectedEventDataQueryBuilderDsl()
        {
        }

        public static ImportOperationRejectedEventDataQueryBuilderDsl Of()
        {
            return new ImportOperationRejectedEventDataQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImportOperationRejectedEventDataQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ImportOperationRejectedEventDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ImportOperationRejectedEventDataQueryBuilderDsl>(p, ImportOperationRejectedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
