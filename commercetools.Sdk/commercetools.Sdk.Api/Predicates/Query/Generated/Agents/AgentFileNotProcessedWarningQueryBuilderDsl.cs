// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentFileNotProcessedWarningQueryBuilderDsl
    {
        public AgentFileNotProcessedWarningQueryBuilderDsl()
        {
        }

        public static AgentFileNotProcessedWarningQueryBuilderDsl Of()
        {
            return new AgentFileNotProcessedWarningQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentFileNotProcessedWarningQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentFileNotProcessedWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentFileNotProcessedWarningQueryBuilderDsl>(p, AgentFileNotProcessedWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentFileNotProcessedWarningQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentFileNotProcessedWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentFileNotProcessedWarningQueryBuilderDsl>(p, AgentFileNotProcessedWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentFileNotProcessedWarningQueryBuilderDsl, string> FileName()
        {
            return new ComparisonPredicateBuilder<AgentFileNotProcessedWarningQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fileName")),
            p => new CombinationQueryPredicate<AgentFileNotProcessedWarningQueryBuilderDsl>(p, AgentFileNotProcessedWarningQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
