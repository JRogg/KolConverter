namespace KolConverter
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(1291, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.filterBox);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3303, 210);
            this.panel2.TabIndex = 3;
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(46, 131);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(1210, 44);
            this.filterBox.TabIndex = 7;
            this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(367, 34);
            this.button5.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(238, 65);
            this.button5.TabIndex = 6;
            this.button5.Text = "Show Keys";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 65);
            this.button4.TabIndex = 5;
            this.button4.Text = "Runecounter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1807, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a Path please";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1549, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "Path";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1033, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // objectListView1
            // 
            this.objectListView1.AllowColumnReorder = true;
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(0, 210);
            this.objectListView1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(3303, 1646);
            this.objectListView1.TabIndex = 6;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(635, 34);
            this.button6.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(238, 65);
            this.button6.TabIndex = 8;
            this.button6.Text = "Torch";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3303, 1856);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Button button6;
    }
}

