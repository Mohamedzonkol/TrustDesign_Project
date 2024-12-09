namespace TrustDesign_Core.Interfaces.Wrappers.Response
{
    public class BaseResponseModel
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public object Data { get; set; }
    }
}
