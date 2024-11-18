using System.Diagnostics;

namespace TrackThread
{
    public partial class frmTrackThread : Form
    {
        private Thread threadA, threadB, threadC, threadD;
        public frmTrackThread()
        {
            InitializeComponent();
           

        }
        private void frmTrackThread_Load(object sender, EventArgs e)
        {
           
        }

        private void lbThread_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lbThread.Text = "-Thread Starts-";
            Debug.WriteLine("-Thread Starts-");
            threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            threadA.Name = "Thread A Process";
            threadB = new Thread(new ThreadStart(MyThreadClass.Thread2));
            threadB.Name = "Thread B Process";
            threadC = new Thread(new ThreadStart(MyThreadClass.Thread1));
            threadC.Name = "Thread C Process";
            threadD = new Thread(new ThreadStart(MyThreadClass.Thread2));
            threadD.Name = "Thread D Process";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;
            threadA.Start();
            threadC.Start();
            threadB.Start();
            threadD.Start();


            threadA.Join();
            threadC.Join();
            threadB.Join();
            threadD.Join();
            Debug.WriteLine("-End of Thread-");
            lbThread.Text = "-End of Thread-";
        }
    }
}
