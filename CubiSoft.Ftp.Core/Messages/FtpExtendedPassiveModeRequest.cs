namespace CubiSoft.Ftp.Messages
{
    public class FtpExtendedPassiveModeRequest : FtpRequest
    {
        public FtpExtendedPassiveModeRequest()
            : base("EPSV")
        {
        }
    }
}