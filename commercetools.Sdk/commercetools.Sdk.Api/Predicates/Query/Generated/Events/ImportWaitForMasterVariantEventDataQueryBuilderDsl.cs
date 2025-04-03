// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Events
{

    public partial class ImportWaitForMasterVariantEventDataQueryBuilderDsl
    {
        public ImportWaitForMasterVariantEventDataQueryBuilderDsl()
        {
        }

        public static ImportWaitForMasterVariantEventDataQueryBuilderDsl Of()
        {
            return new ImportWaitForMasterVariantEventDataQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImportWaitForMasterVariantEventDataQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ImportWaitForMasterVariantEventDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ImportWaitForMasterVariantEventDataQueryBuilderDsl>(p, ImportWaitForMasterVariantEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportWaitForMasterVariantEventDataQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ImportWaitForMasterVariantEventDataQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ImportWaitForMasterVariantEventDataQueryBuilderDsl>(p, ImportWaitForMasterVariantEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ImportWaitForMasterVariantEventDataQueryBuilderDsl, string> ImportContainerKey()
        {
            return new ComparisonPredicateBuilder<ImportWaitForMasterVariantEventDataQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("importContainerKey")),
            p => new CombinationQueryPredicate<ImportWaitForMasterVariantEventDataQueryBuilderDsl>(p, ImportWaitForMasterVariantEventDataQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
