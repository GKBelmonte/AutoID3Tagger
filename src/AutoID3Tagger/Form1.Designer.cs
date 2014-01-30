namespace AutoID3Tagger
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFeatList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMagic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder Select:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mArtistName,
            this.mSongName,
            this.mAlbum,
            this.mFeatList});
            this.dataGridView1.Location = new System.Drawing.Point(41, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 141);
            this.dataGridView1.TabIndex = 3;
            // 
            // mArtistName
            // 
            this.mArtistName.HeaderText = "Artist Name";
            this.mArtistName.Name = "mArtistName";
            // 
            // mSongName
            // 
            this.mSongName.HeaderText = "Song Name";
            this.mSongName.Name = "mSongName";
            // 
            // mAlbum
            // 
            this.mAlbum.HeaderText = "Album Name";
            this.mAlbum.Name = "mAlbum";
            // 
            // mFeatList
            // 
            this.mFeatList.HeaderText = "Featuring Artist";
            this.mFeatList.Name = "mFeatList";
            // 
            // mMagic
            // 
            this.mMagic.Location = new System.Drawing.Point(462, 36);
            this.mMagic.Name = "mMagic";
            this.mMagic.Size = new System.Drawing.Size(97, 22);
            this.mMagic.TabIndex = 4;
            this.mMagic.Text = "Execute";
            this.mMagic.UseVisualStyleBackColor = true;
            this.mMagic.Click += new System.EventHandler(this.mMagic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 343);
            this.Controls.Add(this.mMagic);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFeatList;
        private System.Windows.Forms.Button mMagic;
    }
}

