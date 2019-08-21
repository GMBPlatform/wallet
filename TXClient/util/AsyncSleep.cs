using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXClient.util
{
    public class AsyncSleep
    {
        int MS;
        public AsyncSleep(int MS)
        {
            this.MS = MS;
            start();
        }
        public void start()
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
        }
        ~AsyncSleep()
        {
        }


    }
}
