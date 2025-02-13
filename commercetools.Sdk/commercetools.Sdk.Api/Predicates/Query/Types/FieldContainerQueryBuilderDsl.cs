
namespace commercetools.Sdk.Api.Predicates.Query.Types
{
    public partial class FieldContainerQueryBuilderDsl
    {
        public FieldContainerValueQueryBuilderDsl Field(string fieldName) {
            return new FieldContainerValueQueryBuilderDsl(fieldName);
        }
    }

}


