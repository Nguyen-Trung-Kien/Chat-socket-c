
namespace Server
{
    partial class server
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
            this.btnMessageserver = new System.Windows.Forms.Button();
            this.txbMessageserver = new System.Windows.Forms.TextBox();
            this.lsvMessageserver = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnMessageserver
            // 
            this.btnMessageserver.Location = new System.Drawing.Point(518, 367);
            this.btnMessageserver.Name = "btnMessageserver";
            this.btnMessageserver.Size = new System.Drawing.Size(105, 49);
            this.btnMessageserver.TabIndex = 5;
            this.btnMessageserver.Text = "button1";
            this.btnMessageserver.UseVisualStyleBackColor = true;
            this.btnMessageserver.Click += new System.EventHandler(this.btnMessageserver_Click);
            // 
            // txbMessageserver
            // 
            this.txbMessageserver.Location = new System.Drawing.Point(12, 367);
            this.txbMessageserver.Multiline = true;
            this.txbMessageserver.Name = "txbMessageserver";
            this.txbMessageserver.Size = new System.Drawing.Size(499, 49);
            this.txbMessageserver.TabIndex = 4;
            // 
            // lsvMessageserver
            // 
            this.lsvMessageserver.HideSelection = false;
            this.lsvMessageserver.Location = new System.Drawing.Point(12, 12);
            this.lsvMessageserver.Name = "lsvMessageserver";
            this.lsvMessageserver.Size = new System.Drawing.Size(611, 340);
            this.lsvMessageserver.TabIndex = 3;
            this.lsvMessageserver.UseCompatibleStateImageBehavior = false;
            this.lsvMessageserver.View = System.Windows.Forms.View.List;
            // 
            // server
            // 
            this.AcceptButton = this.btnMessageserver;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 419);
            this.Controls.Add(this.btnMessageserver);
            this.Controls.Add(this.txbMessageserver);
            this.Controls.Add(this.lsvMessageserver);
            this.Name = "server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.server_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessageserver;
        private System.Windows.Forms.TextBox txbMessageserver;
        private System.Windows.Forms.ListView lsvMessageserver;
    }
}

