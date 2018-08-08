namespace Net_Test
{
    partial class Form2
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
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFromDir = new System.Windows.Forms.Label();
            this.txtFromDir = new System.Windows.Forms.TextBox();
            this.txtToDir = new System.Windows.Forms.TextBox();
            this.lblToDir = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAction
            // 
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Delete",
            "Move",
            "Sort",
            "Dummy Files"});
            this.cbAction.Location = new System.Drawing.Point(72, 12);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(438, 28);
            this.cbAction.TabIndex = 0;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Action";
            // 
            // lblFromDir
            // 
            this.lblFromDir.AutoSize = true;
            this.lblFromDir.Location = new System.Drawing.Point(12, 49);
            this.lblFromDir.Name = "lblFromDir";
            this.lblFromDir.Size = new System.Drawing.Size(121, 20);
            this.lblFromDir.TabIndex = 2;
            this.lblFromDir.Text = "From Directory: ";
            // 
            // txtFromDir
            // 
            this.txtFromDir.Location = new System.Drawing.Point(139, 46);
            this.txtFromDir.Name = "txtFromDir";
            this.txtFromDir.Size = new System.Drawing.Size(246, 26);
            this.txtFromDir.TabIndex = 3;
            // 
            // txtToDir
            // 
            this.txtToDir.Location = new System.Drawing.Point(139, 78);
            this.txtToDir.Name = "txtToDir";
            this.txtToDir.Size = new System.Drawing.Size(246, 26);
            this.txtToDir.TabIndex = 5;
            // 
            // lblToDir
            // 
            this.lblToDir.AutoSize = true;
            this.lblToDir.Location = new System.Drawing.Point(12, 81);
            this.lblToDir.Name = "lblToDir";
            this.lblToDir.Size = new System.Drawing.Size(102, 20);
            this.lblToDir.TabIndex = 4;
            this.lblToDir.Text = "To Directory: ";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(391, 78);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(119, 30);
            this.btnAction.TabIndex = 6;
            this.btnAction.Text = "Delete";
            this.btnAction.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 116);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtToDir);
            this.Controls.Add(this.lblToDir);
            this.Controls.Add(this.txtFromDir);
            this.Controls.Add(this.lblFromDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAction);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Editor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFromDir;
        private System.Windows.Forms.TextBox txtFromDir;
        private System.Windows.Forms.TextBox txtToDir;
        private System.Windows.Forms.Label lblToDir;
        private System.Windows.Forms.Button btnAction;
    }
}