namespace App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.tabControlRSS = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxAddandURL = new System.Windows.Forms.GroupBox();
            this.tabControlRSS.SuspendLayout();
            this.groupBoxAddandURL.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(371, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(148, 67);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(6, 19);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(342, 20);
            this.textBoxURL.TabIndex = 1;
            // 
            // tabControlRSS
            // 
            this.tabControlRSS.Controls.Add(this.tabPage1);
            this.tabControlRSS.Controls.Add(this.tabPage2);
            this.tabControlRSS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlRSS.Location = new System.Drawing.Point(0, 125);
            this.tabControlRSS.Name = "tabControlRSS";
            this.tabControlRSS.SelectedIndex = 0;
            this.tabControlRSS.Size = new System.Drawing.Size(647, 187);
            this.tabControlRSS.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddandURL
            // 
            this.groupBoxAddandURL.Controls.Add(this.buttonAdd);
            this.groupBoxAddandURL.Controls.Add(this.textBoxURL);
            this.groupBoxAddandURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAddandURL.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAddandURL.Name = "groupBoxAddandURL";
            this.groupBoxAddandURL.Size = new System.Drawing.Size(647, 85);
            this.groupBoxAddandURL.TabIndex = 0;
            this.groupBoxAddandURL.TabStop = false;
            this.groupBoxAddandURL.Text = "Control Box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 312);
            this.Controls.Add(this.groupBoxAddandURL);
            this.Controls.Add(this.tabControlRSS);
            this.Name = "Form1";
            this.Text = "app";
            this.tabControlRSS.ResumeLayout(false);
            this.groupBoxAddandURL.ResumeLayout(false);
            this.groupBoxAddandURL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TabControl tabControlRSS;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxAddandURL;
    }
}

