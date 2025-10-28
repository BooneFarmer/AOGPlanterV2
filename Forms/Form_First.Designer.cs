using System;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;
using AOGPlanterV2.Properties;

namespace AOGPlanterV2
{
    partial class Form_First
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
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            linkLabelGit = new LinkLabel();
            linkLabelCombineForum = new LinkLabel();
            label12 = new Label();
            lblVersion = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            label4 = new Label();
            label8 = new Label();
            btn_disagree = new Button();
            label9 = new Label();
            button3 = new Button();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 742);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(163, 23);
            label6.TabIndex = 16;
            label6.Text = "Check for Updates\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F);
            label5.Location = new Point(17, 130);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 18);
            label5.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 670);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 15;
            label3.Text = "Discussions at....";
            // 
            // linkLabelGit
            // 
            linkLabelGit.Location = new Point(0, 0);
            linkLabelGit.Name = "linkLabelGit";
            linkLabelGit.Size = new Size(100, 23);
            linkLabelGit.TabIndex = 128;
            // 
            // linkLabelCombineForum
            // 
            linkLabelCombineForum.Location = new Point(0, 0);
            linkLabelCombineForum.Name = "linkLabelCombineForum";
            linkLabelCombineForum.Size = new Size(100, 23);
            linkLabelCombineForum.TabIndex = 129;
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(191, 132);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(662, 57);
            label12.TabIndex = 29;
            label12.Text = "You must make sure that they receive or can get the source code.  And you must show them these terms so they know their rights.  Don't steal others work and call it your own.";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVersion.Location = new Point(301, 24);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(416, 25);
            lblVersion.TabIndex = 34;
            lblVersion.Text = "Terms and Conditions for version 2.1.0";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Resources.Cancel64;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(602, 679);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(181, 124);
            button2.TabIndex = 39;
            button2.Text = "I Want My Mommy";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Resources.OK64;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(832, 679);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(297, 124);
            button1.TabIndex = 10;
            button1.Text = "I Agree to the Terms and Conditions";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(643, 57);
            label1.TabIndex = 127;
            label1.Text = "If you distribute copies of this FREE program, whether gratis or for a fee, improved, changed, you must pass on to the recipients the same freedoms that you received Outlined in the GPLv3 License.";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(191, 335);
            label2.Name = "label2";
            label2.Size = new Size(260, 24);
            label2.TabIndex = 130;
            label2.Text = " USE AT YOUR OWN RISK";
            label2.Click += label2_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(191, 173);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(662, 57);
            label7.TabIndex = 132;
            label7.Text = "AgOpenPlanter is strictly educational software to learn about precision farming systems, hardware to ap communications, and theoretical application of machine monitoring. ";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(191, 221);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(662, 57);
            label4.TabIndex = 133;
            label4.Text = "It is in no way to be used on real equipment in any circumstances.  A simulator is provided to allow the student to safely experience machine monitoring.";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(191, 278);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(662, 57);
            label8.TabIndex = 134;
            label8.Text = "There are no safety systems in the software and none are implied.";
            // 
            // btn_disagree
            // 
            btn_disagree.Image = Resources.Cancel64;
            btn_disagree.Location = new Point(634, 461);
            btn_disagree.Name = "btn_disagree";
            btn_disagree.Size = new Size(95, 88);
            btn_disagree.TabIndex = 135;
            btn_disagree.UseVisualStyleBackColor = true;
            btn_disagree.Click += Disagree_click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(636, 563);
            label9.Name = "label9";
            label9.Size = new Size(93, 24);
            label9.TabIndex = 136;
            label9.Text = "Disagree";
            label9.Click += label9_Click;
            // 
            // button3
            // 
            button3.Image = Resources.OK64;
            button3.Location = new Point(846, 461);
            button3.Name = "button3";
            button3.Size = new Size(95, 88);
            button3.TabIndex = 137;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Agree_click;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(792, 563);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(270, 62);
            label10.TabIndex = 138;
            label10.Text = "I Agree to the Terms and Conditions";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(17, 26);
            label11.Name = "label11";
            label11.Size = new Size(165, 24);
            label11.TabIndex = 139;
            label11.Text = "Ag Open Planter";
            label11.Click += label11_Click;
            // 
            // Form_First
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1124, 634);
            ControlBox = false;
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(btn_disagree);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(button2);
            Controls.Add(lblVersion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(linkLabelGit);
            Controls.Add(linkLabelCombineForum);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "Form_First";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About Ag Open Planter";
            Load += Form_About_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelGit;
        private System.Windows.Forms.LinkLabel linkLabelCombineForum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private Label label2;
        private Label label7;
        private Label label4;
        private Label label8;
        private Button btn_disagree;
        private Label label9;
        private Button button3;
        private Label label10;
        private Label label11;
    }
}