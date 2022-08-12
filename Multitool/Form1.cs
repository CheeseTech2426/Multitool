using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multitool {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            UpdateLabel();
            InitApplication(0);
        }

        /*
         *    ToolID Meaning
         *  0 = Menu
         *  1 = WeBrowser
         *  2 = Calculator
         */

        public int toolID = 0;
        public string defaultWebSite = "www.google.com";
      //public string url = "www.google.com";
        public bool inWebSettings = false;
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        public bool info = false;
        public string InfoCalc = "Multitool v0.1 Calculator\n" +
                                 "Developed by CheeseTech2426";
        public string InfoWeb = "Multitool v0.1 WeBrowser\n" +
                                 "Developed by CheeseTech2426";
        

        public void InitApplication(int toolID) {
            if(toolID == 0) {
                
                this.toolID = 0;
                UpdateLabel();
                ResizeWindow(400, 400);
                FormBorderStyle = FormBorderStyle.Fixed3D;
                webBrowser.ScrollBarsEnabled = true;
                webBrowser.Visible = false;
                weBrowse.Enabled = true;
                weBrowse.Visible = true;
                calcLaunch.Visible = true;
                toolStrip1.Visible = false;
                toolStrip2.Visible = false;
                toolStrip3.Visible = true;
                zero.Visible = false;
                one.Visible = false;
                two.Visible = false;
                three.Visible = false;
                four.Visible = false;
                five.Visible = false;
                six.Visible = false;
                seven.Visible = false;
                eight.Visible = false;
                nine.Visible = false;
                minus.Visible = false;
                plus.Visible = false;
                devide.Visible = false;
                times.Visible = false;
                equals.Visible = false;
                clear.Visible = false;
                calcText.Visible = false;

            }
            if(toolID == 1) {
                toolStripTextBox1.Text = webBrowser.Url.ToString();
                UpdateURL();
                this.toolID = 1;
                UpdateLabel();             
                ResizeWindow(1645, 890);
                FormBorderStyle = FormBorderStyle.Sizable;
                toolStrip1.Visible = true;
                webBrowser.Visible = true;
                calcLaunch.Visible = false;
                toolStrip3.Visible = false;
                weBrowse.Visible = false;
            }
            if (toolID == 2) {
                ResizeWindow(200, 300);
               
                this.toolID = 2;
                UpdateLabel();
                toolStrip2.Visible = true;
                toolStrip3.Visible = false;
                zero.Visible = true;
                one.Visible = true;
                two.Visible = true;
                three.Visible = true;
                four.Visible = true;
                five.Visible = true;
                six.Visible = true;
                seven.Visible = true;
                eight.Visible = true;
                nine.Visible = true;
                minus.Visible = true;
                plus.Visible = true;
                devide.Visible = true;
                times.Visible = true;
                equals.Visible = true;
                clear.Visible = true;
                calcText.Visible = true;
                calcLaunch.Visible = false;
                weBrowse.Visible = false;
            }
        }

        public void UpdateLabel() {
            if (toolID == 0) {
                toolStripLabel1.Text = "Menu";
                toolStripLabel2.Text = "Menu";
                ToolLabel.Text = "Menu";
            } else if (toolID == 1) {
                toolStripLabel1.Text = "WeBrowser";
                toolStripLabel2.Text = "WeBrowser";
                ToolLabel.Text = "WeBrowser";
            }
            
            if(toolID == 2) {
                toolStripLabel1.Text = "Calculator";
                toolStripLabel2.Text = "Calculator";
                ToolLabel.Text = "Calculator";
            }
        }

        public void WebSettings(bool inSettings) {
            if(inSettings == true) {
                defaultWebsiteChanger.Visible = true;
                settingsLabel.Visible = true;
                webBrowser.Dock = DockStyle.Left;
                ResizeWindow(1645, 1000);
            } else if(inSettings == false) {
                defaultWebsiteChanger.Visible = false;
                settingsLabel.Visible = false;
                webBrowser.Dock = DockStyle.Fill;
                ResizeWindow(1645, 890);
            } else {
                System.Windows.Forms.MessageBox.Show("Something Went Wrong. Please Restart The Program. inSettings: " + inSettings + " inWebSettings: " + inWebSettings);
            }
            
        }

        public void ResizeWindow(int Width, int Height) {
            Size = new Size(Width, Height);
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
           
        }



        private void label1_Click(object sender, EventArgs e) {
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            if(toolID == 1 && toolStripTextBox1.Text != toolStripTextBox1.Text) 
              while (true)
                toolStripTextBox1.Text = webBrowser.Url.ToString();
        }


        // Back Button
        private void toolStripButton2_Click(object sender, EventArgs e) {
            toolStripTextBox1.Text = webBrowser.Url.ToString();
            UpdateURL();
            webBrowser.GoBack();

        }

        // Foward Button
        private void toolStripButton3_Click(object sender, EventArgs e) {
            toolStripTextBox1.Text = webBrowser.Url.ToString();
            UpdateURL();
            webBrowser.GoForward();
        }


        // Refresh Button
        private void toolStripButton4_Click(object sender, EventArgs e) {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+') {
                result = num1 + num2;
                calcText.Text = result.ToString();
            } else if (operation == '-') {
                result = num1 - num2;
                calcText.Text = result.ToString();
            } else if (operation == '*') {
                result = num1 * num2;
                calcText.Text = result.ToString();
            } else if (operation == '/') {
                if (num2 != 0) {
                    result = num1 / num2;
                    calcText.Text = result.ToString();
                } else {
                    calcText.Text = "DIV/Zero!";
                }

            }
            toolStripTextBox1.Text = webBrowser.Url.ToString();
            UpdateURL();
            webBrowser.Refresh();
        }

        // Home Button
        private void toolStripButton1_Click(object sender, EventArgs e) {
            toolStripTextBox1.Text = webBrowser.Url.ToString();
            for (int i = 5; i < 5; i++)
                UpdateURL();

            webBrowser.Navigate(defaultWebSite);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e) {
            
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void toolStripButton6_Click(object sender, EventArgs e) {
            inWebSettings = true;
            if (inWebSettings && defaultWebsiteChanger.Visible && settingsLabel.Visible) {
               
                WebSettings(false);
                inWebSettings = false;
            } else if (inWebSettings && !defaultWebsiteChanger.Visible && !settingsLabel.Visible) {
               
                WebSettings(true);
            } else {
                System.Windows.Forms.MessageBox.Show("SOMETHING WENT WRONG " + webBrowser.Dock.ToString() + " " + defaultWebsiteChanger.Enabled.ToString() + " " + inWebSettings);
            }
            
        }

        // Search Button
        private void toolStripButton5_Click(object sender, EventArgs e) {
            string WebPage = toolStripTextBox1.Text.Trim();
            UpdateURL();
            webBrowser.Navigate(WebPage);
            UpdateURL();
            if (IsInputKey(Keys.Enter))
                webBrowser.Navigate(WebPage);
        }

       
        private void toolStripButton7_Click(object sender, EventArgs e) {
            toolStripTextBox1.Text = webBrowser.Url.ToString();
            UpdateURL();
            InitApplication(0);
        }

        private void weBrowse_Click(object sender, EventArgs e) {
            toolStripTextBox1.Text = webBrowser.Url.ToString();
            InitApplication(1);
            UpdateURL();
            weBrowse.Enabled=false;
            weBrowse.Visible=false;
        }

        void UpdateURL() {
           // System.Windows.Forms.MessageBox.Show(webBrowser.Url.ToString());
            toolStripTextBox1.Text = webBrowser.Url.ToString();          
        }

        public void refresh() {
            UpdateURL();
            webBrowser.Refresh();
            while(true)
                toolStripTextBox1.Text = webBrowser.Url.ToString();
        }

        

        private void defaultWebsiteChanger_TextChanged(object sender, EventArgs e) {
            defaultWebSite = defaultWebsiteChanger.Text.ToLower();
        }

        private void settingsLabel_Click(object sender, EventArgs e) {

        }

        private void calcLaunch_Click(object sender, EventArgs e) {
            InitApplication(2);
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void menubutton_Click(object sender, EventArgs e) {
            InitApplication(0);
        }

        private void seven_Click(object sender, EventArgs e) {
            this.calcText.Text = "";
            input += "7";
            this.calcText.Text += input;
        }

        private void five_Click(object sender, EventArgs e) {
            this.calcText.Text = "";
            input += "5";
            this.calcText.Text += input;
        }

        private void nine_Click(object sender, EventArgs e) {
            this.calcText.Text = "";
            input += "9";
            this.calcText.Text += input;
        }

        private void plus_Click(object sender, EventArgs e) {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e) {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void six_Click(object sender, EventArgs e) {
            this.calcText.Text = "";
            input += "6";
            this.calcText.Text += input;
        }

        private void eight_Click(object sender, EventArgs e) {
            this.calcText.Text = "";
            input += "8";
            this.calcText.Text += input;
        }

        private void four_Click(object sender, EventArgs e) {
            this.calcText.Text = "";
            input += "4";
            this.calcText.Text += input;
        }

        private void one_Click(object sender, EventArgs e) {
            this.calcText.Text = "";
            input += "1";
            this.calcText.Text += input;
        }

        private void two_Click(object sender, EventArgs e) {
            this.calcText.Text = "";
            input += "2";
            this.calcText.Text += input;
        }

        private void three_Click(object sender, EventArgs e) {
            this.calcText.Text = "";
            input += "3";
            this.calcText.Text += input;
        }

        private void devide_Click(object sender, EventArgs e) {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void times_Click(object sender, EventArgs e) {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void clear_Click(object sender, EventArgs e) {
            this.calcText.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void equals_Click(object sender, EventArgs e) {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+') {
                result = num1 + num2;
                calcText.Text = result.ToString();
            } else if (operation == '-') {
                result = num1 - num2;
                calcText.Text = result.ToString();
            } else if (operation == '*') {
                result = num1 * num2;
                calcText.Text = result.ToString();
            } else if (operation == '/') {
                if (num2 != 0) {
                    result = num1 / num2;
                    calcText.Text = result.ToString();
                } else {
                    calcText.Text = "DIV/Zero!";
                }

            }
        }

        private void zero_Click(object sender, EventArgs e) {
            this.calcText.Text = "";
            input += "0";
            this.calcText.Text += input;
        }

        private void infoCalc_Click(object sender, EventArgs e) {
            info = true;
            if(info && infoCalcLabel.Visible) {       
                ResizeWindow(200, 300);
                infoCalcLabel.Visible = false;
                info = false;
            } else if(info && !infoCalcLabel.Visible) {
                infoCalcLabel.Text = InfoCalc;
                infoCalcLabel.Visible = true;
                ResizeWindow(400, 300);              
                info = true;
            }
        }

        private void infoWeb_Click(object sender, EventArgs e) {
            info = true;
            if (info && infoCalcLabel.Visible) {
                webBrowser.Dock = DockStyle.Fill;
                ResizeWindow(1645, 1000);
                infoCalcLabel.Visible = false;
                info = false;
            } else if (info && !infoCalcLabel.Visible) {
                infoCalcLabel.Text = InfoWeb;
                infoCalcLabel.Visible = true;
                webBrowser.Dock = DockStyle.Right;
                ResizeWindow(1645, 890);
                info = true;
            }
        }

        private void infoCalcLabel_Click(object sender, EventArgs e) {
            
        }

        private void ToolLabel_Click(object sender, EventArgs e) {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            
        }

        private void toolStripLabel2_Click(object sender, EventArgs e) {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e) {

        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }
    }
}
