
namespace Multitool {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.Multitool = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.weBrowse = new System.Windows.Forms.Button();
            this.defaultWebsiteChanger = new System.Windows.Forms.TextBox();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.calcLaunch = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.menubutton = new System.Windows.Forms.ToolStripButton();
            this.seven = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.calcText = new System.Windows.Forms.Label();
            this.equals = new System.Windows.Forms.Button();
            this.devide = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.infoCalc = new System.Windows.Forms.ToolStripButton();
            this.infoWeb = new System.Windows.Forms.ToolStripButton();
            this.infoCalcLabel = new System.Windows.Forms.Label();
            this.ToolLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(2437, 1015);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.webBrowser.Visible = false;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // Multitool
            // 
            this.Multitool.AutoSize = true;
            this.Multitool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multitool.Location = new System.Drawing.Point(1, 0);
            this.Multitool.Name = "Multitool";
            this.Multitool.Size = new System.Drawing.Size(68, 20);
            this.Multitool.TabIndex = 9;
            this.Multitool.Text = "Multitool";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Web Browser";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolLabel,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton7,
            this.infoWeb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(2437, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolBarWeb";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Back";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Refresh";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Home";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Foward";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(500, 25);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Search";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Settings";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton7.Text = "Menu";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // weBrowse
            // 
            this.weBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("weBrowse.BackgroundImage")));
            this.weBrowse.Cursor = System.Windows.Forms.Cursors.Default;
            this.weBrowse.ForeColor = System.Drawing.SystemColors.Control;
            this.weBrowse.Image = ((System.Drawing.Image)(resources.GetObject("weBrowse.Image")));
            this.weBrowse.Location = new System.Drawing.Point(12, 59);
            this.weBrowse.Name = "weBrowse";
            this.weBrowse.Size = new System.Drawing.Size(75, 73);
            this.weBrowse.TabIndex = 14;
            this.weBrowse.UseVisualStyleBackColor = true;
            this.weBrowse.Click += new System.EventHandler(this.weBrowse_Click);
            // 
            // defaultWebsiteChanger
            // 
            this.defaultWebsiteChanger.Location = new System.Drawing.Point(2735, 143);
            this.defaultWebsiteChanger.Name = "defaultWebsiteChanger";
            this.defaultWebsiteChanger.Size = new System.Drawing.Size(184, 20);
            this.defaultWebsiteChanger.TabIndex = 15;
            this.defaultWebsiteChanger.Text = "www.google.com";
            this.defaultWebsiteChanger.Visible = false;
            this.defaultWebsiteChanger.TextChanged += new System.EventHandler(this.defaultWebsiteChanger_TextChanged);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(2780, 66);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(113, 31);
            this.settingsLabel.TabIndex = 16;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.Visible = false;
            this.settingsLabel.Click += new System.EventHandler(this.settingsLabel_Click);
            // 
            // calcLaunch
            // 
            this.calcLaunch.Image = ((System.Drawing.Image)(resources.GetObject("calcLaunch.Image")));
            this.calcLaunch.Location = new System.Drawing.Point(93, 59);
            this.calcLaunch.Name = "calcLaunch";
            this.calcLaunch.Size = new System.Drawing.Size(75, 73);
            this.calcLaunch.TabIndex = 17;
            this.calcLaunch.UseVisualStyleBackColor = true;
            this.calcLaunch.Click += new System.EventHandler(this.calcLaunch_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.menubutton,
            this.infoCalc});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(2437, 25);
            this.toolStrip2.TabIndex = 18;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // menubutton
            // 
            this.menubutton.Image = ((System.Drawing.Image)(resources.GetObject("menubutton.Image")));
            this.menubutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menubutton.Name = "menubutton";
            this.menubutton.Size = new System.Drawing.Size(58, 22);
            this.menubutton.Text = "Menu";
            this.menubutton.Click += new System.EventHandler(this.menubutton_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(16, 129);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(25, 23);
            this.seven.TabIndex = 73;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(77, 216);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(25, 23);
            this.clear.TabIndex = 98;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // calcText
            // 
            this.calcText.AutoSize = true;
            this.calcText.Location = new System.Drawing.Point(22, 106);
            this.calcText.Name = "calcText";
            this.calcText.Size = new System.Drawing.Size(13, 13);
            this.calcText.TabIndex = 97;
            this.calcText.Text = "0";
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(46, 216);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(25, 23);
            this.equals.TabIndex = 96;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // devide
            // 
            this.devide.Location = new System.Drawing.Point(108, 187);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(25, 23);
            this.devide.TabIndex = 95;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = true;
            this.devide.Click += new System.EventHandler(this.devide_Click);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(108, 216);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(25, 23);
            this.times.TabIndex = 94;
            this.times.Text = "x";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.times_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(108, 158);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(25, 23);
            this.minus.TabIndex = 93;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(108, 129);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(25, 23);
            this.plus.TabIndex = 92;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(15, 216);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(25, 23);
            this.zero.TabIndex = 91;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(77, 129);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(25, 23);
            this.nine.TabIndex = 90;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(46, 129);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(25, 23);
            this.eight.TabIndex = 89;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(77, 158);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(25, 23);
            this.six.TabIndex = 88;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(46, 158);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(25, 23);
            this.five.TabIndex = 87;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(15, 158);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(25, 23);
            this.four.TabIndex = 86;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(77, 187);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(25, 23);
            this.three.TabIndex = 85;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(46, 187);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(25, 23);
            this.two.TabIndex = 84;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(15, 187);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(25, 23);
            this.one.TabIndex = 83;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // infoCalc
            // 
            this.infoCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infoCalc.Image = ((System.Drawing.Image)(resources.GetObject("infoCalc.Image")));
            this.infoCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoCalc.Name = "infoCalc";
            this.infoCalc.Size = new System.Drawing.Size(23, 22);
            this.infoCalc.Text = "toolStripButton8";
            this.infoCalc.ToolTipText = "Info";
            this.infoCalc.Click += new System.EventHandler(this.infoCalc_Click);
            // 
            // infoWeb
            // 
            this.infoWeb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infoWeb.Image = ((System.Drawing.Image)(resources.GetObject("infoWeb.Image")));
            this.infoWeb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoWeb.Name = "infoWeb";
            this.infoWeb.Size = new System.Drawing.Size(23, 22);
            this.infoWeb.Text = "toolStripButton9";
            this.infoWeb.ToolTipText = "Info";
            this.infoWeb.Click += new System.EventHandler(this.infoWeb_Click);
            // 
            // infoCalcLabel
            // 
            this.infoCalcLabel.AutoSize = true;
            this.infoCalcLabel.Location = new System.Drawing.Point(192, 89);
            this.infoCalcLabel.Name = "infoCalcLabel";
            this.infoCalcLabel.Size = new System.Drawing.Size(12, 13);
            this.infoCalcLabel.TabIndex = 99;
            this.infoCalcLabel.Text = "z";
            this.infoCalcLabel.Visible = false;
            this.infoCalcLabel.Click += new System.EventHandler(this.infoCalcLabel_Click);
            // 
            // ToolLabel
            // 
            this.ToolLabel.Name = "ToolLabel";
            this.ToolLabel.Size = new System.Drawing.Size(69, 22);
            this.ToolLabel.Text = "Placeholder";
            this.ToolLabel.Click += new System.EventHandler(this.ToolLabel_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip3.Location = new System.Drawing.Point(0, 50);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(2437, 25);
            this.toolStrip3.TabIndex = 100;
            this.toolStrip3.Text = "toolStrip3";
            this.toolStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip3_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel2.Text = "toolStripLabel2";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2437, 1015);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.infoCalcLabel);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calcText);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.devide);
            this.Controls.Add(this.times);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.defaultWebsiteChanger);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Multitool);
            this.Controls.Add(this.calcLaunch);
            this.Controls.Add(this.weBrowse);
            this.Controls.Add(this.webBrowser);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Multitool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
      //  private System.Windows.Forms.PictureBox backgroudWeb;
        private System.Windows.Forms.Label Multitool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Button weBrowse;
        private System.Windows.Forms.TextBox defaultWebsiteChanger;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button calcLaunch;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton menubutton;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label calcText;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button devide;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.ToolStripButton infoWeb;
        private System.Windows.Forms.ToolStripButton infoCalc;
        private System.Windows.Forms.Label infoCalcLabel;
        private System.Windows.Forms.ToolStripLabel ToolLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

