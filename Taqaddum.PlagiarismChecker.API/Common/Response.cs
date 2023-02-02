namespace Taqaddum.PlagiarismChecker.API.Common
{
    public class Response : IResponse
    {
        public string Status { get; set; }
        public bool Success { get; set; }
        public object Data { get; set; }
        public Response(string status, object data)
        {
            Status = status;
            Data = data;
        }

        public static IResponse CreateSucess() { return new Response() { Success = true, Status = "Success" }; }
        public static IResponse CreateError() { return new Response() { Success = true, Status = "Error" }; }

        public void SetStatus(bool success, string status)
        {
            throw new NotImplementedException();
        }

        public string GetStatus()
        {
            throw new NotImplementedException();
        }

        public void SetData(object data)
        {
            Data = data;
        }

        public object GetData()
        {
            return Data;
        }
    }
}
