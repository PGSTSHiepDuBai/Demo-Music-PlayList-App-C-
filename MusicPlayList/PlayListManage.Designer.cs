namespace MusicPlayList
{
    partial class PlayListManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListManage));
            this.dgvPlayListManage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPlayList = new System.Windows.Forms.Button();
            this.btnDeletePlaylist = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnDelAllPlayList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayListManage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayListManage
            // 
            this.dgvPlayListManage.AllowUserToAddRows = false;
            this.dgvPlayListManage.AllowUserToDeleteRows = false;
            this.dgvPlayListManage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayListManage.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPlayListManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayListManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPlayListManage.Location = new System.Drawing.Point(4, 7);
            this.dgvPlayListManage.Name = "dgvPlayListManage";
            this.dgvPlayListManage.ReadOnly = true;
            this.dgvPlayListManage.RowHeadersWidth = 62;
            this.dgvPlayListManage.RowTemplate.Height = 28;
            this.dgvPlayListManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayListManage.Size = new System.Drawing.Size(928, 284);
            this.dgvPlayListManage.TabIndex = 0;
            this.dgvPlayListManage.DoubleClick += new System.EventHandler(this.dgvPlayListManage_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PlayListName";
            this.Column1.HeaderText = "Tên Playlist";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Length";
            this.Column2.HeaderText = "Số lượng bài hát";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnAddPlayList
            // 
            this.btnAddPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayList.Location = new System.Drawing.Point(246, 340);
            this.btnAddPlayList.Name = "btnAddPlayList";
            this.btnAddPlayList.Size = new System.Drawing.Size(203, 65);
            this.btnAddPlayList.TabIndex = 1;
            this.btnAddPlayList.Text = "Thêm PlayList";
            this.btnAddPlayList.UseVisualStyleBackColor = true;
            this.btnAddPlayList.Click += new System.EventHandler(this.btnAddPlayList_Click);
            // 
            // btnDeletePlaylist
            // 
            this.btnDeletePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlaylist.Location = new System.Drawing.Point(480, 340);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.Size = new System.Drawing.Size(203, 65);
            this.btnDeletePlaylist.TabIndex = 2;
            this.btnDeletePlaylist.Text = "Xóa PlayList";
            this.btnDeletePlaylist.UseVisualStyleBackColor = true;
            this.btnDeletePlaylist.Click += new System.EventHandler(this.btnDeletePlaylist_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(12, 340);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(203, 65);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Phát PlayList";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnDelAllPlayList
            // 
            this.btnDelAllPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAllPlayList.Location = new System.Drawing.Point(714, 340);
            this.btnDelAllPlayList.Name = "btnDelAllPlayList";
            this.btnDelAllPlayList.Size = new System.Drawing.Size(203, 65);
            this.btnDelAllPlayList.TabIndex = 4;
            this.btnDelAllPlayList.Text = "Xóa Tất Cả PlayList";
            this.btnDelAllPlayList.UseVisualStyleBackColor = true;
            this.btnDelAllPlayList.Click += new System.EventHandler(this.btnDelAllPlayList_Click);
            // 
            // PlayListManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 452);
            this.Controls.Add(this.btnDelAllPlayList);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnDeletePlaylist);
            this.Controls.Add(this.btnAddPlayList);
            this.Controls.Add(this.dgvPlayListManage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayListManage";
            this.Text = "Mucsic Playlist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayListManage_FormClosing);
            this.Load += new System.EventHandler(this.PlayListManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayListManage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayListManage;
        private System.Windows.Forms.Button btnAddPlayList;
        private System.Windows.Forms.Button btnDeletePlaylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnDelAllPlayList;
    }
}