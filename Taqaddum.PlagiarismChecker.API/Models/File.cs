namespace Taqaddum.PlagiarismChecker.API.Models
{
    public class FileReq
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public FormFile File { get; set; }
    }
}
