using System.Windows.Forms;
namespace TXClient.config
{
    public class Define
    {
        public string KeyFilePath = Application.StartupPath + "\\KeyList.ini";
        public string IsInfoFilePath = Application.StartupPath + "\\IsInfo.ini";
        public string SigAlgorithm = "secp256r1";
        public string BlockexplorerApiUrl = "https://gmbplatform.io/blockexplorer/wallet/api/";
        public string ApiItemBalance = "balance";
        public string ApiItemKeyGenerate = "generate";
        public string GpsApiUrl = "http://ip-api.com/json";
    }
}