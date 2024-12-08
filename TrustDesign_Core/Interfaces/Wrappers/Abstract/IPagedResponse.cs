namespace TrustDesign_Core.Interfaces.Wrappers.Abstract
{
    public interface IPagedResponse<T> : IResponse
    {
        int PageCounter { get; }
        int TotalItem { get; }
        T Data { get; }
    }
}
