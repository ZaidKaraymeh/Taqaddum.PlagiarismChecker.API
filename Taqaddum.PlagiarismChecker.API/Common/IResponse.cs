namespace Taqaddum.PlagiarismChecker.API.Common
{
    public interface IResponse
    {
        public void SetStatus(bool success, string status);
        public string GetStatus();

        public void SetData(object data);
        public object GetData();
    }
}