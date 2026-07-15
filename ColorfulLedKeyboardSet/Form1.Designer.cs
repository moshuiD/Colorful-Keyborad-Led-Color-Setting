using System.Drawing;
using System.Windows.Forms;

namespace ColorfulLedKeyboardSet
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblModes = new System.Windows.Forms.TableLayoutPanel();
            this.btnModeStrobe = new System.Windows.Forms.Button();
            this.btnModeMusic = new System.Windows.Forms.Button();
            this.btnToggleRainbow = new System.Windows.Forms.Button();
            this.btnModeTemp = new System.Windows.Forms.Button();
            this.btnModeAmbient = new System.Windows.Forms.Button();
            this.btnModeBreath = new System.Windows.Forms.Button();
            this.btnModeLoop = new System.Windows.Forms.Button();
            this.btnModeStatic = new System.Windows.Forms.Button();
            this.chkSafeMode = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlKeyboardColor = new System.Windows.Forms.Panel();
            this.chkStartMinimized = new System.Windows.Forms.CheckBox();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.pnlBrightnessSlider = new System.Windows.Forms.Panel();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.pnlSpeedSlider = new System.Windows.Forms.Panel();
            this.btnCustomColor = new System.Windows.Forms.Button();
            this.flowPresets = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPresetTitle = new System.Windows.Forms.Label();
            this.lblFooterLine = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpSliders = new System.Windows.Forms.Panel();
            this.grpPresets = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tblModes.SuspendLayout();
            this.grpSliders.SuspendLayout();
            this.grpPresets.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblModes
            // 
            this.tblModes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblModes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.tblModes.ColumnCount = 4;
            this.tblModes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblModes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblModes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblModes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblModes.Controls.Add(this.btnModeStatic, 0, 0);
            this.tblModes.Controls.Add(this.btnModeLoop, 1, 0);
            this.tblModes.Controls.Add(this.btnModeBreath, 2, 0);
            this.tblModes.Controls.Add(this.btnModeStrobe, 3, 0);
            this.tblModes.Controls.Add(this.btnModeMusic, 0, 1);
            this.tblModes.Controls.Add(this.btnModeTemp, 1, 1);
            this.tblModes.Controls.Add(this.btnModeAmbient, 2, 1);
            this.tblModes.Controls.Add(this.btnToggleRainbow, 3, 1);
            this.tblModes.Location = new System.Drawing.Point(20, 85);
            this.tblModes.Name = "tblModes";
            this.tblModes.RowCount = 2;
            this.tblModes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblModes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblModes.Size = new System.Drawing.Size(810, 96);
            this.tblModes.TabIndex = 0;
            // 
            // btnModeStrobe
            // 
            this.btnModeStrobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModeStrobe.FlatAppearance.BorderSize = 0;
            this.btnModeStrobe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnModeStrobe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnModeStrobe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeStrobe.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnModeStrobe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.btnModeStrobe.Location = new System.Drawing.Point(610, 3);
            this.btnModeStrobe.Name = "btnModeStrobe";
            this.btnModeStrobe.Size = new System.Drawing.Size(197, 42);
            this.btnModeStrobe.TabIndex = 4;
            this.btnModeStrobe.Text = "闪烁警示";
            this.btnModeStrobe.UseVisualStyleBackColor = true;
            this.btnModeStrobe.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnModeMusic
            // 
            this.btnModeMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModeMusic.FlatAppearance.BorderSize = 0;
            this.btnModeMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnModeMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnModeMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeMusic.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnModeMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.btnModeMusic.Name = "btnModeMusic";
            this.btnModeMusic.TabIndex = 14;
            this.btnModeMusic.Text = "♪ 音乐律动";
            this.btnModeMusic.UseVisualStyleBackColor = true;
            this.btnModeMusic.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnToggleRainbow
            // 
            this.btnToggleRainbow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToggleRainbow.FlatAppearance.BorderSize = 0;
            this.btnToggleRainbow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnToggleRainbow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnToggleRainbow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleRainbow.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnToggleRainbow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.btnToggleRainbow.Name = "btnToggleRainbow";
            this.btnToggleRainbow.TabIndex = 15;
            this.btnToggleRainbow.Text = "🌈 七彩变色 (关)";
            this.btnToggleRainbow.UseVisualStyleBackColor = true;
            this.btnToggleRainbow.Click += new System.EventHandler(this.btnToggleRainbow_Click);
            // 
            // btnModeTemp
            // 
            this.btnModeTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModeTemp.FlatAppearance.BorderSize = 0;
            this.btnModeTemp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnModeTemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnModeTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeTemp.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnModeTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.btnModeTemp.Name = "btnModeTemp";
            this.btnModeTemp.TabIndex = 16;
            this.btnModeTemp.Text = "温度映射";
            this.btnModeTemp.UseVisualStyleBackColor = true;
            this.btnModeTemp.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnModeAmbient
            // 
            this.btnModeAmbient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModeAmbient.FlatAppearance.BorderSize = 0;
            this.btnModeAmbient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnModeAmbient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnModeAmbient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeAmbient.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnModeAmbient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.btnModeAmbient.Name = "btnModeAmbient";
            this.btnModeAmbient.TabIndex = 17;
            this.btnModeAmbient.Text = "屏幕氛围";
            this.btnModeAmbient.UseVisualStyleBackColor = true;
            this.btnModeAmbient.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnModeBreath
            // 
            this.btnModeBreath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModeBreath.FlatAppearance.BorderSize = 0;
            this.btnModeBreath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnModeBreath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnModeBreath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeBreath.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnModeBreath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.btnModeBreath.Location = new System.Drawing.Point(408, 3);
            this.btnModeBreath.Name = "btnModeBreath";
            this.btnModeBreath.Size = new System.Drawing.Size(196, 42);
            this.btnModeBreath.TabIndex = 3;
            this.btnModeBreath.Text = "呼吸灯效";
            this.btnModeBreath.UseVisualStyleBackColor = true;
            this.btnModeBreath.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnModeLoop
            // 
            this.btnModeLoop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModeLoop.FlatAppearance.BorderSize = 0;
            this.btnModeLoop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnModeLoop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnModeLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeLoop.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnModeLoop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.btnModeLoop.Location = new System.Drawing.Point(206, 3);
            this.btnModeLoop.Name = "btnModeLoop";
            this.btnModeLoop.Size = new System.Drawing.Size(196, 42);
            this.btnModeLoop.TabIndex = 2;
            this.btnModeLoop.Text = "渐变循环";
            this.btnModeLoop.UseVisualStyleBackColor = true;
            this.btnModeLoop.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnModeStatic
            // 
            this.btnModeStatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.btnModeStatic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModeStatic.FlatAppearance.BorderSize = 0;
            this.btnModeStatic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeStatic.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnModeStatic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnModeStatic.Location = new System.Drawing.Point(3, 3);
            this.btnModeStatic.Name = "btnModeStatic";
            this.btnModeStatic.Size = new System.Drawing.Size(197, 42);
            this.btnModeStatic.TabIndex = 1;
            this.btnModeStatic.Text = "静态单色";
            this.btnModeStatic.UseVisualStyleBackColor = false;
            this.btnModeStatic.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // chkSafeMode
            // 
            this.chkSafeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSafeMode.AutoSize = true;
            this.chkSafeMode.BackColor = System.Drawing.Color.Transparent;
            this.chkSafeMode.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkSafeMode.ForeColor = System.Drawing.Color.Tomato;
            this.chkSafeMode.Location = new System.Drawing.Point(716, 475);
            this.chkSafeMode.Name = "chkSafeMode";
            this.chkSafeMode.Size = new System.Drawing.Size(114, 23);
            this.chkSafeMode.TabIndex = 1;
            this.chkSafeMode.Text = "安全测试模式";
            this.chkSafeMode.UseVisualStyleBackColor = false;
            this.chkSafeMode.CheckedChanged += new System.EventHandler(this.chkSafeMode_CheckedChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.btnAbout.Location = new System.Drawing.Point(14, 524);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 32);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "关于软件";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "七彩虹键盘灯光控制中心";
            // 
            // pnlKeyboardColor
            // 
            this.pnlKeyboardColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKeyboardColor.BackColor = System.Drawing.Color.Transparent;
            this.pnlKeyboardColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlKeyboardColor.Location = new System.Drawing.Point(20, 48);
            this.pnlKeyboardColor.Name = "pnlKeyboardColor";
            this.pnlKeyboardColor.Size = new System.Drawing.Size(810, 32);
            this.pnlKeyboardColor.TabIndex = 1;
            this.pnlKeyboardColor.Click += new System.EventHandler(this.pnlKeyboardColor_Click);
            this.pnlKeyboardColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKeyboardColor_Paint);
            // 
            // chkStartMinimized
            // 
            this.chkStartMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkStartMinimized.AutoSize = true;
            this.chkStartMinimized.BackColor = System.Drawing.Color.Transparent;
            this.chkStartMinimized.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.chkStartMinimized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.chkStartMinimized.Location = new System.Drawing.Point(210, 475);
            this.chkStartMinimized.Name = "chkStartMinimized";
            this.chkStartMinimized.Size = new System.Drawing.Size(145, 23);
            this.chkStartMinimized.TabIndex = 9;
            this.chkStartMinimized.Text = "启动时最小化到托盘";
            this.chkStartMinimized.UseVisualStyleBackColor = false;
            this.chkStartMinimized.CheckedChanged += new System.EventHandler(this.chkStartMinimized_CheckedChanged);
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoStart.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.chkAutoStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.chkAutoStart.Location = new System.Drawing.Point(20, 475);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(130, 23);
            this.chkAutoStart.TabIndex = 8;
            this.chkAutoStart.Text = "Windows开机自启";
            this.chkAutoStart.UseVisualStyleBackColor = false;
            this.chkAutoStart.CheckedChanged += new System.EventHandler(this.chkAutoStart_CheckedChanged);
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.lblBrightness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(125)))));
            this.lblBrightness.Location = new System.Drawing.Point(15, 110);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(115, 19);
            this.lblBrightness.TabIndex = 7;
            this.lblBrightness.Text = "背光亮度 / 调整值";
            // 
            // pnlBrightnessSlider
            // 
            this.pnlBrightnessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBrightnessSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBrightnessSlider.Location = new System.Drawing.Point(15, 135);
            this.pnlBrightnessSlider.Name = "pnlBrightnessSlider";
            this.pnlBrightnessSlider.Size = new System.Drawing.Size(360, 28);
            this.pnlBrightnessSlider.TabIndex = 6;
            this.pnlBrightnessSlider.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBrightnessSlider_Paint);
            this.pnlBrightnessSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBrightnessSlider_MouseDown);
            this.pnlBrightnessSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBrightnessSlider_MouseMove);
            this.pnlBrightnessSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBrightnessSlider_MouseUp);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(125)))));
            this.lblSpeed.Location = new System.Drawing.Point(15, 15);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(115, 19);
            this.lblSpeed.TabIndex = 5;
            this.lblSpeed.Text = "动画速度 / 频率值";
            // 
            // pnlSpeedSlider
            // 
            this.pnlSpeedSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSpeedSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSpeedSlider.Location = new System.Drawing.Point(15, 45);
            this.pnlSpeedSlider.Name = "pnlSpeedSlider";
            this.pnlSpeedSlider.Size = new System.Drawing.Size(360, 28);
            this.pnlSpeedSlider.TabIndex = 4;
            this.pnlSpeedSlider.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSpeedSlider_Paint);
            this.pnlSpeedSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSpeedSlider_MouseDown);
            this.pnlSpeedSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSpeedSlider_MouseMove);
            this.pnlSpeedSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlSpeedSlider_MouseUp);
            // 
            // btnCustomColor
            // 
            this.btnCustomColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomColor.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.btnCustomColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.btnCustomColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.btnCustomColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomColor.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnCustomColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnCustomColor.Location = new System.Drawing.Point(20, 115);
            this.btnCustomColor.Name = "btnCustomColor";
            this.btnCustomColor.Size = new System.Drawing.Size(360, 36);
            this.btnCustomColor.TabIndex = 3;
            this.btnCustomColor.Text = "自定义颜色...";
            this.btnCustomColor.UseVisualStyleBackColor = false;
            this.btnCustomColor.Click += new System.EventHandler(this.btnCustomColor_Click);
            // 
            // flowPresets
            // 
            this.flowPresets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPresets.BackColor = System.Drawing.Color.Transparent;
            this.flowPresets.Location = new System.Drawing.Point(20, 45);
            this.flowPresets.Name = "flowPresets";
            this.flowPresets.Size = new System.Drawing.Size(360, 50);
            this.flowPresets.TabIndex = 2;
            // 
            // lblPresetTitle
            // 
            this.lblPresetTitle.AutoSize = true;
            this.lblPresetTitle.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.lblPresetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(125)))));
            this.lblPresetTitle.Location = new System.Drawing.Point(15, 15);
            this.lblPresetTitle.Name = "lblPresetTitle";
            this.lblPresetTitle.Size = new System.Drawing.Size(87, 19);
            this.lblPresetTitle.TabIndex = 1;
            this.lblPresetTitle.Text = "预设快捷颜色";
            // 
            // lblFooterLine
            // 
            this.lblFooterLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooterLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblFooterLine.Location = new System.Drawing.Point(20, 515);
            this.lblFooterLine.Name = "lblFooterLine";
            this.lblFooterLine.Size = new System.Drawing.Size(810, 1);
            this.lblFooterLine.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.lblStatus.Location = new System.Drawing.Point(180, 530);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(650, 25);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "硬件驱动已连接";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpSliders
            // 
            this.grpSliders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpSliders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.grpSliders.Controls.Add(this.lblSpeed);
            this.grpSliders.Controls.Add(this.pnlSpeedSlider);
            this.grpSliders.Controls.Add(this.lblBrightness);
            this.grpSliders.Controls.Add(this.pnlBrightnessSlider);
            this.grpSliders.Location = new System.Drawing.Point(20, 205);
            this.grpSliders.Name = "grpSliders";
            this.grpSliders.Size = new System.Drawing.Size(390, 250);
            this.grpSliders.TabIndex = 12;
            this.grpSliders.Paint += new System.Windows.Forms.PaintEventHandler(this.grpPanel_Paint);
            // 
            // grpPresets
            // 
            this.grpPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPresets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.grpPresets.Controls.Add(this.lblPresetTitle);
            this.grpPresets.Controls.Add(this.flowPresets);
            this.grpPresets.Controls.Add(this.btnCustomColor);
            this.grpPresets.Location = new System.Drawing.Point(440, 205);
            this.grpPresets.Name = "grpPresets";
            this.grpPresets.Size = new System.Drawing.Size(390, 250);
            this.grpPresets.TabIndex = 13;
            this.grpPresets.Paint += new System.Windows.Forms.PaintEventHandler(this.grpPanel_Paint);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.trayMenu;
            this.notifyIcon1.Icon = System.Drawing.SystemIcons.Application;
            this.notifyIcon1.Text = "七彩虹键盘灯光控制中心";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShow,
            this.menuExit});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(137, 48);
            // 
            // menuShow
            // 
            this.menuShow.Name = "menuShow";
            this.menuShow.Size = new System.Drawing.Size(136, 22);
            this.menuShow.Text = "显示主界面";
            this.menuShow.Click += new System.EventHandler(this.menuShow_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(136, 22);
            this.menuExit.Text = "退出程序";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(850, 570);
            this.Controls.Add(this.grpPresets);
            this.Controls.Add(this.grpSliders);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFooterLine);
            this.Controls.Add(this.chkStartMinimized);
            this.Controls.Add(this.chkAutoStart);
            this.Controls.Add(this.pnlKeyboardColor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tblModes);
            this.Controls.Add(this.chkSafeMode);
            this.Controls.Add(this.btnAbout);
            this.Icon = System.Drawing.SystemIcons.Application;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "七彩虹键盘灯光控制中心 - 原作者: 墨水";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tblModes.ResumeLayout(false);
            this.grpSliders.ResumeLayout(false);
            this.grpSliders.PerformLayout();
            this.grpPresets.ResumeLayout(false);
            this.grpPresets.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblModes;
        private System.Windows.Forms.Button btnModeStrobe;
        private System.Windows.Forms.Button btnModeBreath;
        private System.Windows.Forms.Button btnModeLoop;
        private System.Windows.Forms.Button btnModeStatic;
        private System.Windows.Forms.CheckBox chkSafeMode;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlKeyboardColor;
        private System.Windows.Forms.Label lblPresetTitle;
        private System.Windows.Forms.Button btnCustomColor;
        private System.Windows.Forms.FlowLayoutPanel flowPresets;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Panel pnlSpeedSlider;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Panel pnlBrightnessSlider;
        private System.Windows.Forms.CheckBox chkStartMinimized;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.Label lblFooterLine;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel grpSliders;
        private System.Windows.Forms.Panel grpPresets;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem menuShow;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Button btnModeMusic;
        private System.Windows.Forms.Button btnToggleRainbow;
        private System.Windows.Forms.Button btnModeTemp;
        private System.Windows.Forms.Button btnModeAmbient;
    }
}
