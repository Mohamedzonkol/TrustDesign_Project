namespace TrustDesign_Core.Interfaces.Wrappers.Abstract
{
    public interface IResponse
    {
        int Status { get; }
        bool Success { get; }
    }
}
