namespace CubiSoft.Ftp.Messages
{
    public class FtpPasswordRequest : FtpRequest
    {
        public FtpPasswordRequest(string password)
            : base("PASS", password)
        {
        }
    }
}