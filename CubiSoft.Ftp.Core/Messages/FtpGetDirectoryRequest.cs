namespace CubiSoft.Ftp.Messages
{
    public class FtpGetDirectoryRequest : FtpRequest
    {
        public FtpGetDirectoryRequest()
            : base("PWD")
        {
        }
    }
}