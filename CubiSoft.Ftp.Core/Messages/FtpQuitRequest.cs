namespace CubiSoft.Ftp.Messages
{
    public class FtpQuitRequest : FtpRequest
    {
        public FtpQuitRequest()
            : base("QUIT")
        {
        }
    }
}