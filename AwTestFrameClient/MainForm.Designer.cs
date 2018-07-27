namespace AwTestFrameClient
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.SelectBrowser2 = new System.Windows.Forms.ComboBox();
            this.SelectBrowser = new System.Windows.Forms.Label();
            this.WebTest = new System.Windows.Forms.CheckBox();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.AndroidConfig = new System.Windows.Forms.GroupBox();
            this.DebugMode = new System.Windows.Forms.CheckBox();
            this.androidType = new System.Windows.Forms.Label();
            this.androidType2 = new System.Windows.Forms.ComboBox();
            this.reset = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.devicesName = new System.Windows.Forms.ComboBox();
            this.adddevice = new System.Windows.Forms.Button();
            this.device1 = new System.Windows.Forms.Label();
            this.AndroidTest = new System.Windows.Forms.CheckBox();
            this.activity2 = new System.Windows.Forms.ComboBox();
            this.activity1 = new System.Windows.Forms.Label();
            this.pagename2 = new System.Windows.Forms.ComboBox();
            this.pagename1 = new System.Windows.Forms.Label();
            this.AppName2 = new System.Windows.Forms.ComboBox();
            this.AppName1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.RunCaseCount = new System.Windows.Forms.Label();
            this.SuccessRatelabel = new System.Windows.Forms.Label();
            this.FailLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.日志输出 = new System.Windows.Forms.GroupBox();
            this.LogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.LogPath = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.RunCaseResult = new System.Windows.Forms.RichTextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.manageTestCase = new System.Windows.Forms.Button();
            this.editTestCase = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.StartTest = new System.Windows.Forms.Button();
            this.CancelTest = new System.Windows.Forms.Button();
            this.TestCases = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.AndroidConfig.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.日志输出.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.GroupBox6);
            this.GroupBox3.Controls.Add(this.num);
            this.GroupBox3.Controls.Add(this.AndroidConfig);
            this.GroupBox3.Controls.Add(this.label3);
            this.GroupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GroupBox3.Location = new System.Drawing.Point(12, 211);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(520, 328);
            this.GroupBox3.TabIndex = 27;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "测试配置";
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.SelectBrowser2);
            this.GroupBox6.Controls.Add(this.SelectBrowser);
            this.GroupBox6.Controls.Add(this.WebTest);
            this.GroupBox6.Location = new System.Drawing.Point(6, 55);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(506, 79);
            this.GroupBox6.TabIndex = 10;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "2";
            // 
            // SelectBrowser2
            // 
            this.SelectBrowser2.Enabled = false;
            this.SelectBrowser2.FormattingEnabled = true;
            this.SelectBrowser2.Items.AddRange(new object[] {
            "Chrome",
            "Firefox",
            "Edge",
            "IE"});
            this.SelectBrowser2.Location = new System.Drawing.Point(84, 36);
            this.SelectBrowser2.Name = "SelectBrowser2";
            this.SelectBrowser2.Size = new System.Drawing.Size(118, 25);
            this.SelectBrowser2.TabIndex = 33;
            // 
            // SelectBrowser
            // 
            this.SelectBrowser.AutoSize = true;
            this.SelectBrowser.Enabled = false;
            this.SelectBrowser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectBrowser.Location = new System.Drawing.Point(7, 39);
            this.SelectBrowser.Name = "SelectBrowser";
            this.SelectBrowser.Size = new System.Drawing.Size(80, 17);
            this.SelectBrowser.TabIndex = 31;
            this.SelectBrowser.Text = "选择浏览器：";
            // 
            // WebTest
            // 
            this.WebTest.AutoSize = true;
            this.WebTest.Enabled = false;
            this.WebTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WebTest.Location = new System.Drawing.Point(7, 0);
            this.WebTest.Name = "WebTest";
            this.WebTest.Size = new System.Drawing.Size(78, 21);
            this.WebTest.TabIndex = 0;
            this.WebTest.Text = "WEB测试";
            this.WebTest.UseVisualStyleBackColor = true;
            this.WebTest.CheckedChanged += new System.EventHandler(this.WebTest_CheckedChanged);
            // 
            // num
            // 
            this.num.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.num.Enabled = false;
            this.num.Location = new System.Drawing.Point(83, 26);
            this.num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(43, 23);
            this.num.TabIndex = 8;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AndroidConfig
            // 
            this.AndroidConfig.Controls.Add(this.DebugMode);
            this.AndroidConfig.Controls.Add(this.androidType);
            this.AndroidConfig.Controls.Add(this.androidType2);
            this.AndroidConfig.Controls.Add(this.reset);
            this.AndroidConfig.Controls.Add(this.button2);
            this.AndroidConfig.Controls.Add(this.devicesName);
            this.AndroidConfig.Controls.Add(this.adddevice);
            this.AndroidConfig.Controls.Add(this.device1);
            this.AndroidConfig.Controls.Add(this.AndroidTest);
            this.AndroidConfig.Controls.Add(this.activity2);
            this.AndroidConfig.Controls.Add(this.activity1);
            this.AndroidConfig.Controls.Add(this.pagename2);
            this.AndroidConfig.Controls.Add(this.pagename1);
            this.AndroidConfig.Controls.Add(this.AppName2);
            this.AndroidConfig.Controls.Add(this.AppName1);
            this.AndroidConfig.Location = new System.Drawing.Point(6, 140);
            this.AndroidConfig.Name = "AndroidConfig";
            this.AndroidConfig.Size = new System.Drawing.Size(505, 181);
            this.AndroidConfig.TabIndex = 1;
            this.AndroidConfig.TabStop = false;
            this.AndroidConfig.Text = "GroupBox5";
            // 
            // DebugMode
            // 
            this.DebugMode.AutoSize = true;
            this.DebugMode.Enabled = false;
            this.DebugMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DebugMode.Location = new System.Drawing.Point(290, 27);
            this.DebugMode.Name = "DebugMode";
            this.DebugMode.Size = new System.Drawing.Size(75, 21);
            this.DebugMode.TabIndex = 37;
            this.DebugMode.Text = "调试模式";
            this.DebugMode.UseVisualStyleBackColor = true;
            // 
            // androidType
            // 
            this.androidType.AutoSize = true;
            this.androidType.Enabled = false;
            this.androidType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.androidType.Location = new System.Drawing.Point(6, 28);
            this.androidType.Name = "androidType";
            this.androidType.Size = new System.Drawing.Size(59, 17);
            this.androidType.TabIndex = 35;
            this.androidType.Text = "测试类型:";
            // 
            // androidType2
            // 
            this.androidType2.Enabled = false;
            this.androidType2.FormattingEnabled = true;
            this.androidType2.Items.AddRange(new object[] {
            "APP",
            "WAP"});
            this.androidType2.Location = new System.Drawing.Point(66, 25);
            this.androidType2.Name = "androidType2";
            this.androidType2.Size = new System.Drawing.Size(65, 25);
            this.androidType2.TabIndex = 36;
            this.androidType2.Text = "APP";
            this.androidType2.SelectedIndexChanged += new System.EventHandler(this.androidType2_SelectedIndexChanged);
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Enabled = false;
            this.reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reset.Location = new System.Drawing.Point(137, 27);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(147, 21);
            this.reset.TabIndex = 34;
            this.reset.Text = "不重置应用不清除缓存";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(316, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 30);
            this.button2.TabIndex = 33;
            this.button2.Text = "刷新设备";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // devicesName
            // 
            this.devicesName.Enabled = false;
            this.devicesName.FormattingEnabled = true;
            this.devicesName.Location = new System.Drawing.Point(66, 56);
            this.devicesName.Name = "devicesName";
            this.devicesName.Size = new System.Drawing.Size(244, 25);
            this.devicesName.TabIndex = 32;
            // 
            // adddevice
            // 
            this.adddevice.Enabled = false;
            this.adddevice.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.adddevice.ForeColor = System.Drawing.SystemColors.Desktop;
            this.adddevice.Location = new System.Drawing.Point(405, 52);
            this.adddevice.Name = "adddevice";
            this.adddevice.Size = new System.Drawing.Size(94, 30);
            this.adddevice.TabIndex = 31;
            this.adddevice.Text = "添加设备";
            this.adddevice.UseVisualStyleBackColor = true;
            this.adddevice.Click += new System.EventHandler(this.adddevice_Click);
            // 
            // device1
            // 
            this.device1.AutoSize = true;
            this.device1.Enabled = false;
            this.device1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.device1.Location = new System.Drawing.Point(7, 61);
            this.device1.Name = "device1";
            this.device1.Size = new System.Drawing.Size(68, 17);
            this.device1.TabIndex = 29;
            this.device1.Text = "测试设备：";
            // 
            // AndroidTest
            // 
            this.AndroidTest.AutoSize = true;
            this.AndroidTest.Enabled = false;
            this.AndroidTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AndroidTest.Location = new System.Drawing.Point(6, -1);
            this.AndroidTest.Name = "AndroidTest";
            this.AndroidTest.Size = new System.Drawing.Size(98, 21);
            this.AndroidTest.TabIndex = 0;
            this.AndroidTest.Text = "Android测试";
            this.AndroidTest.UseVisualStyleBackColor = true;
            this.AndroidTest.CheckedChanged += new System.EventHandler(this.AndroidTest_CheckedChanged);
            // 
            // activity2
            // 
            this.activity2.Enabled = false;
            this.activity2.FormattingEnabled = true;
            this.activity2.Location = new System.Drawing.Point(66, 147);
            this.activity2.Name = "activity2";
            this.activity2.Size = new System.Drawing.Size(433, 25);
            this.activity2.TabIndex = 8;
            // 
            // activity1
            // 
            this.activity1.AutoSize = true;
            this.activity1.Enabled = false;
            this.activity1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.activity1.Location = new System.Drawing.Point(7, 150);
            this.activity1.Name = "activity1";
            this.activity1.Size = new System.Drawing.Size(60, 17);
            this.activity1.TabIndex = 7;
            this.activity1.Text = "Activity：";
            // 
            // pagename2
            // 
            this.pagename2.Enabled = false;
            this.pagename2.FormattingEnabled = true;
            this.pagename2.Location = new System.Drawing.Point(66, 116);
            this.pagename2.Name = "pagename2";
            this.pagename2.Size = new System.Drawing.Size(433, 25);
            this.pagename2.TabIndex = 6;
            // 
            // pagename1
            // 
            this.pagename1.AutoSize = true;
            this.pagename1.Enabled = false;
            this.pagename1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pagename1.Location = new System.Drawing.Point(7, 119);
            this.pagename1.Name = "pagename1";
            this.pagename1.Size = new System.Drawing.Size(44, 17);
            this.pagename1.TabIndex = 5;
            this.pagename1.Text = "包名：";
            // 
            // AppName2
            // 
            this.AppName2.Enabled = false;
            this.AppName2.FormattingEnabled = true;
            this.AppName2.Location = new System.Drawing.Point(66, 85);
            this.AppName2.Name = "AppName2";
            this.AppName2.Size = new System.Drawing.Size(244, 25);
            this.AppName2.TabIndex = 2;
            this.AppName2.SelectedIndexChanged += new System.EventHandler(this.AppName2_SelectedIndexChanged);
            // 
            // AppName1
            // 
            this.AppName1.AutoSize = true;
            this.AppName1.Enabled = false;
            this.AppName1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AppName1.Location = new System.Drawing.Point(7, 88);
            this.AppName1.Name = "AppName1";
            this.AppName1.Size = new System.Drawing.Size(68, 17);
            this.AppName1.TabIndex = 1;
            this.AppName1.Text = "应用名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "设置线程数：";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Label2);
            this.GroupBox4.Controls.Add(this.ProgressLabel);
            this.GroupBox4.Controls.Add(this.Label4);
            this.GroupBox4.Controls.Add(this.Label8);
            this.GroupBox4.Controls.Add(this.Label9);
            this.GroupBox4.Controls.Add(this.RunCaseCount);
            this.GroupBox4.Controls.Add(this.SuccessRatelabel);
            this.GroupBox4.Controls.Add(this.FailLabel);
            this.GroupBox4.Controls.Add(this.PassLabel);
            this.GroupBox4.Controls.Add(this.Label16);
            this.GroupBox4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.GroupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GroupBox4.Location = new System.Drawing.Point(12, 112);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(520, 93);
            this.GroupBox4.TabIndex = 26;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "执行情况";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label2.Location = new System.Drawing.Point(115, 29);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 30);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "执行进度";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProgressLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProgressLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProgressLabel.Location = new System.Drawing.Point(115, 58);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(100, 25);
            this.ProgressLabel.TabIndex = 13;
            this.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label4.Location = new System.Drawing.Point(6, 29);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(110, 30);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "测试用例总计";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.SystemColors.Control;
            this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label8.Location = new System.Drawing.Point(214, 29);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(100, 30);
            this.Label8.TabIndex = 4;
            this.Label8.Text = "Pass";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.SystemColors.Control;
            this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label9.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Label9.Location = new System.Drawing.Point(313, 29);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(100, 30);
            this.Label9.TabIndex = 5;
            this.Label9.Text = "Fail";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RunCaseCount
            // 
            this.RunCaseCount.BackColor = System.Drawing.SystemColors.Control;
            this.RunCaseCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RunCaseCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RunCaseCount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RunCaseCount.Location = new System.Drawing.Point(6, 58);
            this.RunCaseCount.Name = "RunCaseCount";
            this.RunCaseCount.Size = new System.Drawing.Size(110, 25);
            this.RunCaseCount.TabIndex = 6;
            this.RunCaseCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuccessRatelabel
            // 
            this.SuccessRatelabel.BackColor = System.Drawing.SystemColors.Control;
            this.SuccessRatelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SuccessRatelabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SuccessRatelabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SuccessRatelabel.Location = new System.Drawing.Point(412, 58);
            this.SuccessRatelabel.Name = "SuccessRatelabel";
            this.SuccessRatelabel.Size = new System.Drawing.Size(100, 25);
            this.SuccessRatelabel.TabIndex = 10;
            this.SuccessRatelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FailLabel
            // 
            this.FailLabel.BackColor = System.Drawing.SystemColors.Control;
            this.FailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FailLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FailLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FailLabel.Location = new System.Drawing.Point(313, 58);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(100, 25);
            this.FailLabel.TabIndex = 7;
            this.FailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassLabel
            // 
            this.PassLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PassLabel.Location = new System.Drawing.Point(214, 58);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(100, 25);
            this.PassLabel.TabIndex = 8;
            this.PassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.SystemColors.Control;
            this.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label16.Location = new System.Drawing.Point(412, 29);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(100, 30);
            this.Label16.TabIndex = 9;
            this.Label16.Text = "成功率";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 日志输出
            // 
            this.日志输出.BackColor = System.Drawing.SystemColors.Control;
            this.日志输出.Controls.Add(this.LogRichTextBox);
            this.日志输出.Controls.Add(this.button10);
            this.日志输出.Controls.Add(this.button5);
            this.日志输出.Controls.Add(this.LogPath);
            this.日志输出.Controls.Add(this.Label5);
            this.日志输出.Controls.Add(this.RunCaseResult);
            this.日志输出.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.日志输出.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.日志输出.Location = new System.Drawing.Point(537, 8);
            this.日志输出.Name = "日志输出";
            this.日志输出.Size = new System.Drawing.Size(535, 531);
            this.日志输出.TabIndex = 25;
            this.日志输出.TabStop = false;
            this.日志输出.Text = "执行日志";
            // 
            // LogRichTextBox
            // 
            this.LogRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogRichTextBox.Font = new System.Drawing.Font("微软雅黑", 7.5F);
            this.LogRichTextBox.Location = new System.Drawing.Point(5, 182);
            this.LogRichTextBox.Name = "LogRichTextBox";
            this.LogRichTextBox.Size = new System.Drawing.Size(524, 342);
            this.LogRichTextBox.TabIndex = 26;
            this.LogRichTextBox.Text = "";
            this.LogRichTextBox.TextChanged += new System.EventHandler(this.LogRichTextBox_TextChanged);
            this.LogRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogRichTextBox_KeyPress);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button10.Location = new System.Drawing.Point(423, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(106, 30);
            this.button10.TabIndex = 25;
            this.button10.Text = "清空控制台日志";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(359, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 30);
            this.button5.TabIndex = 23;
            this.button5.Text = "打开";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // LogPath
            // 
            this.LogPath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.LogPath.Location = new System.Drawing.Point(96, 23);
            this.LogPath.Name = "LogPath";
            this.LogPath.Size = new System.Drawing.Size(257, 23);
            this.LogPath.TabIndex = 22;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Label5.Location = new System.Drawing.Point(8, 26);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(92, 17);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "日志保存位置：";
            // 
            // RunCaseResult
            // 
            this.RunCaseResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RunCaseResult.Font = new System.Drawing.Font("微软雅黑", 7.5F);
            this.RunCaseResult.Location = new System.Drawing.Point(5, 55);
            this.RunCaseResult.Name = "RunCaseResult";
            this.RunCaseResult.Size = new System.Drawing.Size(524, 121);
            this.RunCaseResult.TabIndex = 1;
            this.RunCaseResult.Text = "";
            this.RunCaseResult.TextChanged += new System.EventHandler(this.RunCaseResult_TextChanged);
            this.RunCaseResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RunCaseResult_KeyPress);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Refresh);
            this.GroupBox1.Controls.Add(this.manageTestCase);
            this.GroupBox1.Controls.Add(this.editTestCase);
            this.GroupBox1.Controls.Add(this.report);
            this.GroupBox1.Controls.Add(this.StartTest);
            this.GroupBox1.Controls.Add(this.CancelTest);
            this.GroupBox1.Controls.Add(this.TestCases);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GroupBox1.Location = new System.Drawing.Point(12, 9);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new System.Drawing.Size(519, 96);
            this.GroupBox1.TabIndex = 24;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "测试用例";
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Refresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Refresh.Location = new System.Drawing.Point(428, 16);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(83, 30);
            this.Refresh.TabIndex = 27;
            this.Refresh.Text = "刷新";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // manageTestCase
            // 
            this.manageTestCase.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.manageTestCase.ForeColor = System.Drawing.SystemColors.Desktop;
            this.manageTestCase.Location = new System.Drawing.Point(316, 57);
            this.manageTestCase.Name = "manageTestCase";
            this.manageTestCase.Size = new System.Drawing.Size(96, 31);
            this.manageTestCase.TabIndex = 26;
            this.manageTestCase.Text = "管理测试用例";
            this.manageTestCase.UseVisualStyleBackColor = true;
            this.manageTestCase.Click += new System.EventHandler(this.manageTestCase_Click);
            // 
            // editTestCase
            // 
            this.editTestCase.Enabled = false;
            this.editTestCase.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.editTestCase.ForeColor = System.Drawing.SystemColors.Desktop;
            this.editTestCase.Location = new System.Drawing.Point(214, 57);
            this.editTestCase.Name = "editTestCase";
            this.editTestCase.Size = new System.Drawing.Size(96, 31);
            this.editTestCase.TabIndex = 24;
            this.editTestCase.Text = "编辑测试用例";
            this.editTestCase.UseVisualStyleBackColor = true;
            this.editTestCase.Click += new System.EventHandler(this.editTestCase_Click);
            // 
            // report
            // 
            this.report.Enabled = false;
            this.report.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.report.ForeColor = System.Drawing.SystemColors.Desktop;
            this.report.Location = new System.Drawing.Point(416, 57);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(96, 31);
            this.report.TabIndex = 23;
            this.report.Text = "查看测试报告";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // StartTest
            // 
            this.StartTest.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartTest.Enabled = false;
            this.StartTest.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.StartTest.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StartTest.Location = new System.Drawing.Point(10, 57);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(96, 31);
            this.StartTest.TabIndex = 22;
            this.StartTest.Text = "开始";
            this.StartTest.UseVisualStyleBackColor = true;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // CancelTest
            // 
            this.CancelTest.Enabled = false;
            this.CancelTest.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.CancelTest.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CancelTest.Location = new System.Drawing.Point(112, 57);
            this.CancelTest.Name = "CancelTest";
            this.CancelTest.Size = new System.Drawing.Size(96, 31);
            this.CancelTest.TabIndex = 25;
            this.CancelTest.Text = "停止";
            this.CancelTest.UseVisualStyleBackColor = true;
            this.CancelTest.Click += new System.EventHandler(this.CancelTest_Click);
            // 
            // TestCases
            // 
            this.TestCases.FormattingEnabled = true;
            this.TestCases.Location = new System.Drawing.Point(104, 20);
            this.TestCases.Name = "TestCases";
            this.TestCases.Size = new System.Drawing.Size(318, 25);
            this.TestCases.TabIndex = 1;
            this.TestCases.SelectedIndexChanged += new System.EventHandler(this.TestCases_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(6, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(92, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "选择测试用例：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 549);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.日志输出);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "AwTestFrame";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.AndroidConfig.ResumeLayout(false);
            this.AndroidConfig.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.日志输出.ResumeLayout(false);
            this.日志输出.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.NumericUpDown num;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.GroupBox AndroidConfig;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox devicesName;
        private System.Windows.Forms.Button adddevice;
        internal System.Windows.Forms.Label device1;
        internal System.Windows.Forms.CheckBox AndroidTest;
        internal System.Windows.Forms.ComboBox activity2;
        internal System.Windows.Forms.Label activity1;
        internal System.Windows.Forms.ComboBox pagename2;
        internal System.Windows.Forms.Label pagename1;
        internal System.Windows.Forms.ComboBox AppName2;
        internal System.Windows.Forms.Label AppName1;
        private System.Windows.Forms.GroupBox GroupBox4;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label RunCaseCount;
        private System.Windows.Forms.Label SuccessRatelabel;
        private System.Windows.Forms.Label FailLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.GroupBox 日志输出;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox LogPath;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.RichTextBox RunCaseResult;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button manageTestCase;
        private System.Windows.Forms.Button editTestCase;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button StartTest;
        private System.Windows.Forms.Button CancelTest;
        internal System.Windows.Forms.ComboBox TestCases;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.ComboBox SelectBrowser2;
        internal System.Windows.Forms.Label SelectBrowser;
        internal System.Windows.Forms.CheckBox WebTest;
        internal System.Windows.Forms.Label androidType;
        internal System.Windows.Forms.ComboBox androidType2;
        internal System.Windows.Forms.CheckBox reset;
        internal System.Windows.Forms.CheckBox DebugMode;
        private System.Windows.Forms.RichTextBox LogRichTextBox;
    }
}

