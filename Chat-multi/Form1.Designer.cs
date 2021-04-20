
namespace Chat_multi
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
            this.btnMessage1 = new System.Windows.Forms.Button();
            this.txbMessage1 = new System.Windows.Forms.TextBox();
            this.lsvMessage1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnMessage1
            // 
            this.btnMessage1.Location = new System.Drawing.Point(518, 367);
            this.btnMessage1.Name = "btnMessage1";
            this.btnMessage1.Size = new System.Drawing.Size(105, 49);
            this.btnMessage1.TabIndex = 5;
            this.btnMessage1.Text = "button1";
            this.btnMessage1.UseVisualStyleBackColor = true;
            this.btnMessage1.Click += new System.EventHandler(this.btnMessage1_Click);
            // 
            // txbMessage1
            // 
            this.txbMessage1.Location = new System.Drawing.Point(12, 367);
            this.txbMessage1.Multiline = true;
            this.txbMessage1.Name = "txbMessage1";
            this.txbMessage1.Size = new System.Drawing.Size(499, 49);
            this.txbMessage1.TabIndex = 4;
            this.txbMessage1.TextChanged += new System.EventHandler(this.txbMessage1_TextChanged);
            // 
            // lsvMessage1
            // 
            this.lsvMessage1.HideSelection = false;
            this.lsvMessage1.Location = new System.Drawing.Point(12, 12);
            this.lsvMessage1.Name = "lsvMessage1";
            this.lsvMessage1.Size = new System.Drawing.Size(611, 340);
            this.lsvMessage1.TabIndex = 3;
            this.lsvMessage1.UseCompatibleStateImageBehavior = false;
            this.lsvMessage1.View = System.Windows.Forms.View.List;
            this.lsvMessage1.SelectedIndexChanged += new System.EventHandler(this.lsvMessage1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 422);
            this.Controls.Add(this.btnMessage1);
            this.Controls.Add(this.txbMessage1);
            this.Controls.Add(this.lsvMessage1);
            this.Name = "Form1";
            this.Text = "  server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage1;
        private System.Windows.Forms.TextBox txbMessage1;
        private System.Windows.Forms.ListView lsvMessage1;
    }
}

