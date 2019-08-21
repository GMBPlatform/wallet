using System.Windows.Forms;
namespace TXClient.util
{
    public class Define
    {
        public string KeyFilePath = Application.StartupPath + "\\KeyList.ini";
        public string IsInfoFilePath = Application.StartupPath + "\\IsInfo.ini";
        public string SigAlgorithm = "secp256r1";
        public string BlockexplorerApiUrl = "https://gmbplatform.io/blockexplorer/wallet/api/balance";
        public string SCN_IP;
        public int SCN_PORT;
    }
}