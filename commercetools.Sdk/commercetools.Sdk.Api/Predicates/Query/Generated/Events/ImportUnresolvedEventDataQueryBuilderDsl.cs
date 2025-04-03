// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class ImportUnresolvedEventDataQueryBuilderDsl
    {
        public ImportUnresolvedEventDataQueryBuilderDsl()
        {
        }

        public static ImportUnresolvedEventDataQueryBuilderDsl Of()
        {
            return new ImportUnresolvedEventDataQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImportUnresolvedEventDataQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ImportUnresolvedEventDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ImportUnresolvedEventDataQueryBuilderDsl>(p, ImportUnresolvedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportUnresolvedEventDataQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ImportUnresolvedEventDataQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ImportUnresolvedEventDataQueryBuilderDsl>(p, ImportUnresolvedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportUnresolvedEventDataQueryBuilderDsl, string> ImportContainerKey()
        {
            return new ComparisonPredicateBuilder<ImportUnresolvedEventDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("importContainerKey")),
            p => new CombinationQueryPredicate<ImportUnresolvedEventDataQueryBuilderDsl>(p, ImportUnresolvedEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
