namespace MusicPlayList
{
    partial class NamedPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NamedPlaylist));
            this.btnNamedPlaylist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitNamedPlaylist = new System.Windows.Forms.Button();
            this.txtEnterNamePlaylist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNamedPlaylist
            // 
            this.btnNamedPlaylist.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNamedPlaylist.Location = new System.Drawing.Point(77, 257);
            this.btnNamedPlaylist.Name = "btnNamedPlaylist";
            this.btnNamedPlaylist.Size = new System.Drawing.Size(164, 51);
            this.btnNamedPlaylist.TabIndex = 2;
            this.btnNamedPlaylist.Text = "Tạo PlayList";
            this.btnNamedPlaylist.UseVisualStyleBackColor = false;
            this.btnNamedPlaylist.Click += new System.EventHandler(this.btnNamedPlaylist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập tên playlist:";
            // 
            // btnExitNamedPlaylist
            // 
            this.btnExitNamedPlaylist.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExitNamedPlaylist.Location = new System.Drawing.Point(448, 257);
            this.btnExitNamedPlaylist.Name = "btnExitNamedPlaylist";
            this.btnExitNamedPlaylist.Size = new System.Drawing.Size(164, 51);
            this.btnExitNamedPlaylist.TabIndex = 5;
            this.btnExitNamedPlaylist.Text = "Thoát";
            this.btnExitNamedPlaylist.UseVisualStyleBackColor = false;
            this.btnExitNamedPlaylist.Click += new System.EventHandler(this.btnExitNamedPlaylist_Click);
            // 
            // txtEnterNamePlaylist
            // 
            this.txtEnterNamePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterNamePlaylist.Location = new System.Drawing.Point(175, 135);
            this.txtEnterNamePlaylist.Name = "txtEnterNamePlaylist";
            this.txtEnterNamePlaylist.Size = new System.Drawing.Size(409, 30);
            this.txtEnterNamePlaylist.TabIndex = 6;
            // 
            // NamedPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 384);
            this.Controls.Add(this.txtEnterNamePlaylist);
            this.Controls.Add(this.btnExitNamedPlaylist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNamedPlaylist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NamedPlaylist";
            this.Text = "Create Playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNamedPlaylist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitNamedPlaylist;
        private System.Windows.Forms.TextBox txtEnterNamePlaylist;
    }
}