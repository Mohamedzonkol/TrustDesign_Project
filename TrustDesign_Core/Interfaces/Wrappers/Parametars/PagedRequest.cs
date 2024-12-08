namespace TrustDesign_Core.Interfaces.Wrappers.Parametars
{
    public class PagedRequest
    {
        public bool IsSearch { get; set; } = false;
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
    internal class PageFilter
    {
        public string GroubBy { get; set; }
        public PageRule[] Rules { get; set; }
    }
    public class PageRule
    {
        public string Field { get; set; }
        public string Operator { get; set; }
        public string Data { get; set; }
    }
    public enum WhereOperator
    {
        Equal,
        NotEqual,
        LessThan,
        LessThanOrEqual,
        GreaterThan,
        GreaterThanOrEqual,
        StartsWith,
        EndsWith,
        Contains,
        NotContains
    }
}
