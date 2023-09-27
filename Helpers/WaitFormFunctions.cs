using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManagementUI.Helpers
{
    public class WaitFormFunctions
    {
        ProgressForm progress;
        Thread loadthread;

        public void Show()
        {
            loadthread = new Thread(new ThreadStart(LoadingProcess));
            loadthread.Start();
        }

        public void Show(Form parent)
        {
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadthread.Start(parent);
        }

        public void Close()
        {
            if (progress != null)
            {
                progress.BeginInvoke(new System.Threading.ThreadStart(progress.CloseWaitForm));
                progress = null;
                loadthread = null;
            }
        }

        private void LoadingProcess()
        {
            progress = new ProgressForm();
            progress.ShowDialog();
        }

        private void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            progress = new ProgressForm(parent1);
            progress.ShowDialog();
        }
    }
}
