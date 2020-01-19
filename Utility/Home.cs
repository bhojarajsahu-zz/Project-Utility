using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Utilities;
using System.Data;
using System.Data.Sql;

namespace Utilities
{
    public partial class Home : Form
    {
        #region Prevent Lock
        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_SYSTEM_REQUIRED = 0x00000001,
            ES_DISPLAY_REQUIRED = 0x00000002,
            // Legacy flag, should not be used.
            // ES_USER_PRESENT   = 0x00000004,
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
        }
        public static class SleepUtil
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
        }
        public void PreventSleep()
        {
            if (SleepUtil.SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS
                | EXECUTION_STATE.ES_DISPLAY_REQUIRED
                | EXECUTION_STATE.ES_SYSTEM_REQUIRED
                | EXECUTION_STATE.ES_AWAYMODE_REQUIRED) == 0) //Away mode for Windows >= Vista
                SleepUtil.SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS
                    | EXECUTION_STATE.ES_DISPLAY_REQUIRED
                    | EXECUTION_STATE.ES_SYSTEM_REQUIRED); //Windows < Vista, forget away mode
        }
        #endregion
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);
        public Home()
        {
            InitializeComponent();
        }

        private void buttonXMLFormatter_Click(object sender, EventArgs e)
        {
            Utility newUtility = new Utility();
            newUtility.Show();
        }
        private void buttonPropertyGenerator_Click(object sender, EventArgs e)
        {
            PropertyGeneratorFromXML newPGX = new PropertyGeneratorFromXML();
            newPGX.Show();
            //PropertyGenerator newPG = new PropertyGenerator();
            //newPG.Show();
        }
        private void buttonKillVSProcess_Click(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();

            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName == "Microsoft.Alm.Shared.Remoting.RemoteContainer.dll" || theprocess.ProcessName == "Microsoft.VisualStudio.Web.Host")
                    theprocess.Kill();

            }
        }
        private void Home_Load(object sender, EventArgs e)
        {
            PreventSleep();
        }
        public void deactivateListener()
        {
            sRecognize.RecognizeAsyncStop();
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            deactivateListener();
        }


        private void buttonCheckConnection_Click(object sender, EventArgs e)
        {
            CheckConnection newCheck = new CheckConnection();
            newCheck.Show();
        }

        private void buttonTransactionEnq_Click(object sender, EventArgs e)
        {
            TransactionEnquiry newenquiry = new TransactionEnquiry();
            newenquiry.Show();
        }

        private void timerCurrent_Tick(object sender, EventArgs e)
        {
            //dateFormatChange();


        }

        private void buttonSQLServer_Click(object sender, EventArgs e)
        {
            SqlServerInstance newInstance = new SqlServerInstance();
            newInstance.Show();
        }

        private void buttonUI_Click(object sender, EventArgs e)
        {
            GenerateUI newUIGenerate = new GenerateUI();
            //newUIGenerate.setTransaction("");
            newUIGenerate.setFileLocation("");
            newUIGenerate.Show();
        }

        private void buttonTXNLogMgr_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"D:\Research Work\EventViewerVisualizer\EventViewerVisualizer\bin\Debug\EventViewerVisualizer.exe");
            }
            catch { }
        }

    }
}
