using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class ImportContainerCreatedEventDataQueryBuilderDsl
    {
        public ImportContainerCreatedEventDataQueryBuilderDsl()
        {
        }

        public static ImportContainerCreatedEventDataQueryBuilderDsl Of()
        {
            return new ImportContainerCreatedEventDataQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImportContainerCreatedEventDataQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ImportContainerCreatedEventDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ImportContainerCreatedEventDataQueryBuilderDsl>(p, ImportContainerCreatedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportContainerCreatedEventDataQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ImportContainerCreatedEventDataQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ImportContainerCreatedEventDataQueryBuilderDsl>(p, ImportContainerCreatedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportContainerCreatedEventDataQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ImportContainerCreatedEventDataQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ImportContainerCreatedEventDataQueryBuilderDsl>(p, ImportContainerCreatedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportContainerCreatedEventDataQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ImportContainerCreatedEventDataQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ImportContainerCreatedEventDataQueryBuilderDsl>(p, ImportContainerCreatedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
