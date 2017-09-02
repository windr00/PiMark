using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PiMark
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            addBar = once;
            addText = all;
        }

        private delegate void refreshBar();

        private delegate void refreshLable();

        refreshBar addBar;

        refreshLable addText;
        
        public void once() {
            if (!this.barAll.InvokeRequired)
            {
                lock (this.barAll)
                {
                    this.barAll.Value = this.barAll.Value + 1;
                }
                this.lbFinished.Text = this.barAll.Value.ToString();
            }
            else
            {
                this.barAll.Invoke(addBar);
            }

        }

        public void all()
        {
            if (!this.lbTime.InvokeRequired)
            {
                count++;
                if (count >= threads.Count)
                {
                    UInt64 end = UInt64.Parse(DateTime.Now.ToFileTimeUtc().ToString());

                    this.lbTime.Text = ((int)((1.0/((end - start) / 345))*100000000 * ((double)numTimes.Value / 100.0))).ToString();
                    threads.Clear();
                }
            }
            else
            {
                this.lbTime.Invoke(addText);
            }
        }


        int count = 0;
        List<Thread> threads = new List<Thread>();
        UInt64 start = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.barAll.Value = 0;
            this.barAll.Maximum = (int)numTimes.Value;
            for (int i = 0; i < numThread.Value; i++)
            {
                PiCalculator calculator = null;
                if (i == numThread.Value - 1)
                {
                    calculator = new PiCalculator((uint)(numTimes.Value / numThread.Value + (numTimes.Value % numThread.Value)), once, all);
                }
                else
                {
                    calculator = new PiCalculator((uint)(numTimes.Value / numThread.Value), once, all);
                }
                threads.Add(new Thread(new ThreadStart(calculator.run)));
            }


            start = UInt64.Parse(DateTime.Now.ToFileTimeUtc().ToString());
            foreach (var t in threads)
            {
                t.Start();
            }
        }
    }
}
