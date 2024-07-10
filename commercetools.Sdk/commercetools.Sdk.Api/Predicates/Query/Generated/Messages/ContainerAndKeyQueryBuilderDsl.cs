// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ContainerAndKeyQueryBuilderDsl
    {
        public ContainerAndKeyQueryBuilderDsl()
        {
        }

        public static ContainerAndKeyQueryBuilderDsl Of()
        {
            return new ContainerAndKeyQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ContainerAndKeyQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ContainerAndKeyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ContainerAndKeyQueryBuilderDsl>(p, ContainerAndKeyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ContainerAndKeyQueryBuilderDsl, string> Container()
        {
            return new ComparisonPredicateBuilder<ContainerAndKeyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("container")),
            p => new CombinationQueryPredicate<ContainerAndKeyQueryBuilderDsl>(p, ContainerAndKeyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
