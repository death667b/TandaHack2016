using System.Collections.Generic;

namespace tecGUI
{
    partial class Update
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
            this.empNamelistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qualistBox = new System.Windows.Forms.ListBox();
            this.quatextBox = new System.Windows.Forms.TextBox();
            this.expiretextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // empNamelistBox
            // 
            this.empNamelistBox.FormattingEnabled = true;
            this.empNamelistBox.Location = new System.Drawing.Point(28, 55);
            this.empNamelistBox.Name = "empNamelistBox";
            this.empNamelistBox.Size = new System.Drawing.Size(151, 277);
            this.empNamelistBox.TabIndex = 0;
            this.empNamelistBox.SelectedIndexChanged += new System.EventHandler(this.empNamelistBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emploee Name";
            // 
            // qualistBox
            // 
            this.qualistBox.FormattingEnabled = true;
            this.qualistBox.Location = new System.Drawing.Point(185, 55);
            this.qualistBox.Name = "qualistBox";
            this.qualistBox.Size = new System.Drawing.Size(180, 277);
            this.qualistBox.TabIndex = 2;
            // 
            // quatextBox
            // 
            this.quatextBox.Location = new System.Drawing.Point(473, 55);
            this.quatextBox.Name = "quatextBox";
            this.quatextBox.Size = new System.Drawing.Size(154, 20);
            this.quatextBox.TabIndex = 3;
            // 
            // expiretextBox
            // 
            this.expiretextBox.Location = new System.Drawing.Point(473, 90);
            this.expiretextBox.Name = "expiretextBox";
            this.expiretextBox.Size = new System.Drawing.Size(154, 20);
            this.expiretextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qualification";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Expiry";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(473, 148);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(473, 197);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(473, 248);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Update Employee Qualifications";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 354);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expiretextBox);
            this.Controls.Add(this.quatextBox);
            this.Controls.Add(this.qualistBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empNamelistBox);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox empNamelistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox qualistBox;
        private System.Windows.Forms.TextBox quatextBox;
        private System.Windows.Forms.TextBox expiretextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label4;
    }
}