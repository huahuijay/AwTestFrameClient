using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwTestFrameClient
{
    public delegate void DelReadStdOutput(string result);
    public delegate void StartTestButtonEnable();
    public partial class MainForm : Form
    {
        public event DelReadStdOutput ReadStdOutput;
        public event StartTestButtonEnable StartTestButton;
        public static int PassCount = 0;
        public static int FailCount = 0;
        public static int CaseCount = 0;
        public static int RunCount = 0;
        public MainForm()
        {
            InitializeComponent();
            Init();
            setSelectTestCase();
        }

        private void Init()
        {
            //将相应函数注册到委托事件中  
            ReadStdOutput += new DelReadStdOutput(ReadStdOutputAction);
            StartTestButton += new StartTestButtonEnable(StartTestEnableAction);
        }

        private void RealAction(string StartFileName, string Arguments)
        {
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = StartFileName;      // 命令  
            CmdProcess.StartInfo.Arguments = Arguments;
            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口  
            CmdProcess.StartInfo.UseShellExecute = false;
            CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入  
            CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出  
            CmdProcess.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
            CmdProcess.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            CmdProcess.ErrorDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            CmdProcess.EnableRaisingEvents = true;                      // 启用Exited事件 
            CmdProcess.Exited += new EventHandler(CmdProcess_Exited);   // 注册进程结束事件  
            CmdProcess.Start();
            CmdProcess.BeginOutputReadLine();
            CmdProcess.BeginErrorReadLine();
        }

        // 执行结束后触发  
        private void CmdProcess_Exited(object sender, EventArgs e)
        {
            this.Invoke(StartTestButton);
        }

        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.Invoke(ReadStdOutput, new object[] { e.Data });
            }
        }

        private void ReadStdOutputAction(string result)
        {
                if (result.Contains("--- P") || result.Contains("--- F"))
                {
                    RunCount++;
                    if (result.Contains("--- Pass"))
                    {
                        PassCount++;
                        PassLabel.Text = PassCount.ToString();
                        this.RunCaseResult.SelectionColor = Color.Green;
                        this.RunCaseResult.AppendText(result + "\r\n");

                    }
                    else if (result.Contains("--- Fail"))
                    {
                        FailCount++;
                        FailLabel.Text = FailCount.ToString();
                        this.RunCaseResult.SelectionColor = Color.Red;
                        this.RunCaseResult.AppendText(result + "\r\n");
                    }
                    float C = (float)RunCount / (float)CaseCount;
                    Double D = Math.Round(C, 2);
                    float A = (float)PassCount / (float)CaseCount;
                    Double B = Math.Round(A, 2);
                    ProgressLabel.Text = D * 100 + "%";
                    SuccessRatelabel.Text = B * 100 + "%";
                }
                else if (result.Contains("--- S"))
                {
                    this.RunCaseResult.SelectionColor = Color.Black;
                    this.RunCaseResult.AppendText(result + "\r\n");
                }
                else
                {
                    this.LogRichTextBox.SelectionColor = Color.Black;
                    this.LogRichTextBox.AppendText(result + "\r\n");
                }
        }

        private void StartTestEnableAction()
        {
            //执行结束后启动开始执行按钮
            this.StartTest.Enabled = true;
            this.CancelTest.Enabled = false;
            MessageBoxEx.Show(this,"测试脚本已执行完成");
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            //初始化统计数据
            PassLabel.Text = "0";
            FailLabel.Text = "0";
            ProgressLabel.Text = "0%";
            SuccessRatelabel.Text = "0%";
            CaseCount = ExcelUtils.GetRunCaseNum(TestCases.Text);
            RunCaseCount.Text = CaseCount.ToString();
            RunCount = 0;
            PassCount = 0;
            FailCount = 0;
            this.StartTest.Enabled = false;
            this.CancelTest.Enabled = true;
            StringBuilder sb = new StringBuilder();
            if (WebTest.Checked == true)
            {
                if (SelectBrowser2.Text != "")
                {
                    sb.Append("-testcase ");
                    sb.Append(TestCases.Text);
                    sb.Append(" -type web ");
                    sb.Append("-browser ");
                    sb.Append(SelectBrowser2.Text);
                    sb.Append(" -thread ");
                    sb.Append(num.Text);
                    RealAction("./StartAwTest.exe", sb.ToString());
                }
                else
                {
                    MessageBoxEx.Show(this, "请完整填写测试配置", "Error !");
                    this.StartTest.Enabled = true;
                    this.CancelTest.Enabled = false;
                }
            }
            else if (AndroidTest.Checked == true)
            {
                if (devicesName.Text == "" || AppName2.Text == "" || pagename2.Text == "" || activity2.Text == "")
                {
                    MessageBoxEx.Show(this, "请完整填写测试配置", "Error !");
                    this.StartTest.Enabled = true;
                    this.CancelTest.Enabled = false;
                }
                else
                {
                    sb.Append("-testcase ");
                    sb.Append(TestCases.Text);
                    sb.Append(" -type ");
                    sb.Append(androidType2.Text);
                    sb.Append(" -os Android");
                    sb.Append(" -device ");
                    sb.Append(devicesName.Text);
                    sb.Append(" -thread "); 
                    sb.Append(num.Text);
                    sb.Append(" -appname ");
                    sb.Append(AppName2.Text);
                    sb.Append(" -packagename ");
                    sb.Append(pagename2.Text);
                    sb.Append(" -activity ");
                    sb.Append(activity2.Text);
                    if (reset.Checked)
                    {
                        sb.Append(" -norest true");
                    }
                    if (DebugMode.Checked)
                    {
                        sb.Append(" -debug true");
                    }
                    RealAction("./StartAwTest.exe", sb.ToString());
                }
            }
            else
            {
                MessageBoxEx.Show(this, "请完整填写测试配置", "Error !");

              
                //MessageBoxEx.Show("请完整填写测试配置", "Error !");
                this.StartTest.Enabled = true;
                this.CancelTest.Enabled = false;
            }
        }

        private void setSelectTestCase()
        {
            TestCases.Text = "";
            TestCases.Items.Clear();
            List<string> fileNames = FileUtils.getAllfolderName();
            for (int i = 0; i < fileNames.Count; i++)
            {
                this.TestCases.Items.AddRange(new object[] { fileNames[i] });
            }
        }

        private void TestCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogPath.Text = Directory.GetCurrentDirectory() + @"\testCase\" + TestCases.Text + @"\test-result\log\RunLog.log";
            StartTest.Enabled = true;
            CancelTest.Enabled = false;
            editTestCase.Enabled = true;
            report.Enabled = true;
            num.Enabled = true;
            //初始化统计数据
            PassLabel.Text = "0";
            FailLabel.Text = "0";
            ProgressLabel.Text = "0%";
            SuccessRatelabel.Text = "0%";
            CaseCount = ExcelUtils.GetRunCaseNum(TestCases.Text);
            RunCaseCount.Text = CaseCount.ToString();
            RunCount = 0;
            PassCount = 0;
            FailCount = 0;
            this.AndroidTest.Enabled = true;
            this.WebTest.Enabled = true;
            this.num.Maximum = CaseCount;
        }

        private void WebTest_CheckedChanged(object sender, EventArgs e)
        {
            if (WebTest.Checked)
            {
                SelectBrowser2.Enabled = true;
                SelectBrowser.Enabled = true;
                this.AndroidTest.Enabled = false;
            }
            else
            {
                this.WebTest.Enabled = true;
                SelectBrowser2.Enabled = false;
                SelectBrowser.Enabled = false;
                SelectBrowser2.Text = "";
                this.AndroidTest.Enabled = true;
                this.AppName1.Enabled = false;
                this.AppName2.Enabled = false;
                this.reset.Enabled = false;
                this.device1.Enabled = false;
                this.devicesName.Enabled = false;
                this.button2.Enabled = false;
                this.adddevice.Enabled = false;
                this.pagename1.Enabled = false;
                this.pagename2.Enabled = false;
                this.activity1.Enabled = false;
                this.activity2.Enabled = false;
                this.AppName2.Text = "";
                this.reset.Checked = false;
                this.devicesName.Text = "";
                this.pagename2.Text = "";
                this.activity2.Text = "";
                this.AppName2.Items.Clear();
                this.pagename2.Items.Clear();
                this.activity2.Items.Clear();
                this.devicesName.Items.Clear();
            }
        }


        /*
         * 获取apps文件夹下的应用名称
         */
        public void setAppName()
        {
            List<string> fileNames = FileUtils.getAllFileName(this.TestCases.Text);
            for (int i = 0; i < fileNames.Count; i++)
            {
                this.AppName2.Items.AddRange(new object[] { fileNames[i] });
            }
        }

        /*
        * 获取devices文件夹下的安卓设备名称
        */

        public void setDeviceName()
        {
            List<string> DeviceNames = ExcelUtils.GetDevicesName();
            for (int i = 0; i < DeviceNames.Count; i++)
            {
                this.devicesName.Items.AddRange(new object[] { DeviceNames[i] });
            }
        }

       

        private void Refresh_Click(object sender, EventArgs e)
        {
            setSelectTestCase();
            PassLabel.Text = "";
            FailLabel.Text = "";
            ProgressLabel.Text = "";
            SuccessRatelabel.Text = "";
            RunCaseCount.Text = "";
            StartTest.Enabled = false;
            CancelTest.Enabled = false;
            editTestCase.Enabled = false;
            report.Enabled = false;
            num.Enabled = false;
            this.num.Enabled = false;
            this.AndroidTest.Enabled = false;
            this.AndroidTest.Checked = false;
            this.WebTest.Enabled = false;
            this.AppName1.Enabled = false;
            this.AppName2.Enabled = false;
            this.reset.Enabled = false;
            this.device1.Enabled = false;
            this.devicesName.Enabled = false;
            this.button2.Enabled = false;
            this.adddevice.Enabled = false;
            this.pagename1.Enabled = false;
            this.pagename2.Enabled = false;
            this.activity1.Enabled = false;
            this.activity2.Enabled = false;
            this.AppName2.Text = "";
            this.reset.Checked = false;
            this.devicesName.Text = "";
            this.pagename2.Text = "";
            this.activity2.Text = "";
            this.AppName2.Items.Clear();
            this.pagename2.Items.Clear();
            this.activity2.Items.Clear();
            this.devicesName.Items.Clear();
            this.num.Text = "1";
        }

        private void AndroidTest_CheckedChanged(object sender, EventArgs e)
        {
            if (AndroidTest.Checked)
            {
                this.num.Enabled = true;
                this.WebTest.Enabled = false;
                SelectBrowser2.Enabled = false;
                SelectBrowser.Enabled = false;
                SelectBrowser2.Text = "";
                this.androidType.Enabled = true;
                this.androidType2.Enabled = true;
                this.AppName1.Enabled = true;
                this.AppName2.Enabled = true;
                this.reset.Enabled = true;
                this.device1.Enabled = true;
                this.devicesName.Enabled = true;
                this.button2.Enabled = true;
                this.adddevice.Enabled = true;
                this.pagename1.Enabled = true;
                this.pagename2.Enabled = true;
                this.activity1.Enabled = true;
                this.activity2.Enabled = true;
                this.DebugMode.Enabled = true;
                setAppName();
                setDeviceName();
                
            }
            else
            {
                this.WebTest.Enabled = true;
                this.androidType.Enabled = false;
                this.androidType2.Enabled = false;
                this.androidType2.Text = "APP";
                this.AppName1.Enabled = false;
                this.AppName2.Enabled = false;
                this.reset.Enabled = false;
                this.device1.Enabled = false;
                this.devicesName.Enabled = false;
                this.button2.Enabled = false;
                this.adddevice.Enabled = false;
                this.pagename1.Enabled = false;
                this.pagename2.Enabled = false;
                this.activity1.Enabled = false;
                this.activity2.Enabled = false;
                this.AppName2.Text = "";
                this.reset.Checked = false;
                this.devicesName.Text = "";
                this.pagename2.Text = "";
                this.activity2.Text = "";
                this.AppName2.Items.Clear();
                this.pagename2.Items.Clear();
                this.activity2.Items.Clear();
                this.devicesName.Items.Clear();
                this.DebugMode.Enabled = false;
                this.DebugMode.Checked = false;
            }
        }

        private void editTestCase_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + "/testCase/" + TestCases.Text + "/main.xlsx";
            System.Diagnostics.Process.Start(path);
        }

        private void CancelTest_Click(object sender, EventArgs e)
        {
            string message = CmdUtils.RunCmd("tasklist /fi \"imagename eq StartAwTest.exe\"");
            if (!message.Contains("没有运行的任务匹配"))
            {
                DialogResult dr = MessageBoxEx.Show(this, "确定终止脚本执行？", "停止确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    CmdUtils.RunCmd("taskkill /f /t /im StartAwTest.exe");
                    this.RunCaseResult.SelectionColor = Color.Black;
                    this.RunCaseResult.AppendText("已终止脚本执行\r\n");
                }
            }
            this.StartTest.Enabled = true;
            this.CancelTest.Enabled = false;
        }

        private void report_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + "/testCase/" + TestCases.Text + "/test-result";
            if (Directory.Exists(path))
            {
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                MessageBoxEx.Show(this, "暂无测试报告可展示");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists(LogPath.Text))
            {
                Process.Start(LogPath.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.LogRichTextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.devicesName.Text = "";
            this.devicesName.Items.Clear();
            setDeviceName();
        }

        private void adddevice_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + "/devices/AndroidDevices.xlsx";
            System.Diagnostics.Process.Start(path);
        }

        private void AppName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pagename2.Items.Clear();
            string FileName = "./tools/aapt.exe";
            string Arguments = "dump badging " + "./testCase/" + TestCases.Text + "/apps/" + AppName2.Text;
            string output = CmdUtils.runCommand(FileName, Arguments);
            string RegexStr1 = @"package: name='(.*?)' ";
            Match mat1 = Regex.Match(output, RegexStr1);
            for (int i = 0; i < mat1.Groups.Count; i++)
            {
                if (!mat1.Groups[i].Value.Contains("='"))
                {
                    this.pagename2.Items.AddRange(new object[] { mat1.Groups[i].Value });
                }
            }
            this.pagename2.Text = mat1.Groups[1].Value;
            activity2.Items.Clear();
            string RegexStr2 = @"launchable-activity: name='(.*?)'  ";
            Match mat2 = Regex.Match(output, RegexStr2);
            for (int i = 0; i < mat2.Groups.Count; i++)
            {
                if (!mat2.Groups[i].Value.Contains("='"))
                {
                    this.activity2.Items.AddRange(new object[] { mat2.Groups[i].Value });
                }
            }
            this.activity2.Text = mat2.Groups[1].Value;
        }

        private void manageTestCase_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + "/testCase/";
            System.Diagnostics.Process.Start(path);
        }
        /*
         * 使用户输入失败
         */
        private void RunCaseResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LogRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LogRichTextBox_TextChanged(object sender, EventArgs e)
        {
            LogRichTextBox.SelectionStart = LogRichTextBox.Text.Length;
            LogRichTextBox.ScrollToCaret();
        }

        private void RunCaseResult_TextChanged(object sender, EventArgs e)
        {
            RunCaseResult.SelectionStart = RunCaseResult.Text.Length;
            RunCaseResult.ScrollToCaret();
        }

        private void androidType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (androidType2.Text.Equals("WAP"))
            {
                this.reset.Checked = false;
                this.reset.Enabled = false;
                this.pagename1.Enabled = false;
                this.pagename2.Enabled = false;
                this.activity1.Enabled = false;
                this.activity2.Enabled = false;
                this.AppName1.Enabled = false;
                this.AppName2.Enabled = false;
                this.AppName2.Text = "";
                this.devicesName.Text = "";
                this.pagename2.Text = "";
                this.activity2.Text = "";
            }
            else
            {
                this.reset.Checked = false;
                this.reset.Enabled = true;
                this.pagename1.Enabled = true;
                this.pagename2.Enabled = true;
                this.activity1.Enabled = true;
                this.activity2.Enabled = true;
                this.AppName1.Enabled = true;
                this.AppName2.Enabled = true;
                this.AppName2.Text = "";
                this.devicesName.Text = "";
                this.pagename2.Text = "";
                this.activity2.Text = "";
            }  
        }  
    }
}
