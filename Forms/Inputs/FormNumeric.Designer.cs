using Microsoft.Win32;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace AOGPlanterV2
{
    partial class FormNumeric
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
            tboxNumber = new TextBox();
            lblMax = new Label();
            lblMin = new Label();
            keypad1 = new Keypad.NumKeypad();
            btnDistanceUp = new ProXoft.WinForms.RepeatButton();
            btnDistanceDn = new ProXoft.WinForms.RepeatButton();
            SuspendLayout();
            // 
            // tboxNumber
            // 
            tboxNumber.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tboxNumber.Location = new Point(173, 7);
            tboxNumber.Name = "tboxNumber";
            tboxNumber.ReadOnly = true;
            tboxNumber.Size = new Size(282, 52);
            tboxNumber.TabIndex = 1;
            tboxNumber.Text = "234.5";
            tboxNumber.TextAlign = HorizontalAlignment.Center;
            tboxNumber.Click += tboxNumber_Click;
            // 
            // lblMax
            // 
            lblMax.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMax.Location = new Point(332, 62);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(125, 36);
            lblMax.TabIndex = 6;
            lblMax.Text = "88.8";
            lblMax.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMin
            // 
            lblMin.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMin.Location = new Point(195, 62);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(125, 36);
            lblMin.TabIndex = 7;
            lblMin.Text = "2.1";
            lblMin.TextAlign = ContentAlignment.TopCenter;
            // 
            // keypad1
            // 
            keypad1.BackColor = SystemColors.ActiveCaption;
            keypad1.Location = new Point(0, 112);
            keypad1.Margin = new Padding(5, 3, 5, 3);
            keypad1.Name = "keypad1";
            keypad1.Size = new Size(454, 429);
            keypad1.TabIndex = 5;
            // 
            // btnDistanceUp
            // 
            btnDistanceUp.BackColor = Color.Transparent;
            btnDistanceUp.BackgroundImageLayout = ImageLayout.Zoom;
            btnDistanceUp.FlatAppearance.BorderColor = Color.Blue;
            btnDistanceUp.FlatAppearance.BorderSize = 0;
            btnDistanceUp.FlatStyle = FlatStyle.Flat;
            btnDistanceUp.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDistanceUp.Image = Properties.Resources.UpArrow64;
            btnDistanceUp.Location = new Point(89, 3);
            btnDistanceUp.Margin = new Padding(2, 3, 2, 3);
            btnDistanceUp.Name = "btnDistanceUp";
            btnDistanceUp.Size = new Size(83, 92);
            btnDistanceUp.TabIndex = 148;
            btnDistanceUp.UseVisualStyleBackColor = false;
            btnDistanceUp.MouseDown += BtnDistanceUp_MouseDown;
            // 
            // btnDistanceDn
            // 
            btnDistanceDn.BackColor = Color.Transparent;
            btnDistanceDn.BackgroundImageLayout = ImageLayout.Zoom;
            btnDistanceDn.FlatAppearance.BorderColor = Color.Blue;
            btnDistanceDn.FlatAppearance.BorderSize = 0;
            btnDistanceDn.FlatStyle = FlatStyle.Flat;
            btnDistanceDn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDistanceDn.Image = Properties.Resources.DnArrow64;
            btnDistanceDn.Location = new Point(2, 3);
            btnDistanceDn.Margin = new Padding(2, 3, 2, 3);
            btnDistanceDn.Name = "btnDistanceDn";
            btnDistanceDn.Size = new Size(83, 92);
            btnDistanceDn.TabIndex = 147;
            btnDistanceDn.UseVisualStyleBackColor = false;
            btnDistanceDn.MouseDown += BtnDistanceDn_MouseDown;
            // 
            // FormNumeric
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(470, 545);
            Controls.Add(btnDistanceUp);
            Controls.Add(btnDistanceDn);
            Controls.Add(tboxNumber);
            Controls.Add(keypad1);
            Controls.Add(lblMin);
            Controls.Add(lblMax);
            Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(486, 584);
            Name = "FormNumeric";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Enter a Value";
            Load += FormNumeric_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tboxNumber;
        private Keypad.NumKeypad keypad1;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private ProXoft.WinForms.RepeatButton btnDistanceUp;
        private ProXoft.WinForms.RepeatButton btnDistanceDn;
    }
}