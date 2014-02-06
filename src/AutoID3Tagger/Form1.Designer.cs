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
            this.tableInferred = new System.Windows.Forms.DataGridView();
            this.mArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFeatList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMagic = new System.Windows.Forms.Button();
            this.id3TagInfoTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mSave = new System.Windows.Forms.Button();
            this.mInferSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableInferred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id3TagInfoTable)).BeginInit();
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
            // tableInferred
            // 
            this.tableInferred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInferred.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mArtistName,
            this.mAlbum,
            this.mSongName,
            this.mFeatList});
            this.tableInferred.Location = new System.Drawing.Point(12, 83);
            this.tableInferred.Name = "tableInferred";
            this.tableInferred.Size = new System.Drawing.Size(452, 248);
            this.tableInferred.TabIndex = 3;
            // 
            // mArtistName
            // 
            this.mArtistName.HeaderText = "Artist Name";
            this.mArtistName.Name = "mArtistName";
            // 
            // mAlbum
            // 
            this.mAlbum.HeaderText = "Album Name";
            this.mAlbum.Name = "mAlbum";
            // 
            // mSongName
            // 
            this.mSongName.HeaderText = "Song Name";
            this.mSongName.Name = "mSongName";
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
            this.mMagic.Size = new System.Drawing.Size(100, 25);
            this.mMagic.TabIndex = 4;
            this.mMagic.Text = "Read";
            this.mMagic.UseVisualStyleBackColor = true;
            this.mMagic.Click += new System.EventHandler(this.mMagic_Click);
            // 
            // id3TagInfoTable
            // 
            this.id3TagInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.id3TagInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.id3TagInfoTable.Location = new System.Drawing.Point(481, 83);
            this.id3TagInfoTable.Name = "id3TagInfoTable";
            this.id3TagInfoTable.Size = new System.Drawing.Size(449, 248);
            this.id3TagInfoTable.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Artist Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Album Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Song Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Featuring Artist";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inferred information from file name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Information from ID3 tags";
            // 
            // mSave
            // 
            this.mSave.Location = new System.Drawing.Point(809, 35);
            this.mSave.Name = "mSave";
            this.mSave.Size = new System.Drawing.Size(100, 25);
            this.mSave.TabIndex = 8;
            this.mSave.Text = "Save Tags";
            this.mSave.UseVisualStyleBackColor = true;
            this.mSave.Click += new System.EventHandler(this.mSave_Click);
            // 
            // mInferSelected
            // 
            this.mInferSelected.Location = new System.Drawing.Point(703, 36);
            this.mInferSelected.Name = "mInferSelected";
            this.mInferSelected.Size = new System.Drawing.Size(100, 25);
            this.mInferSelected.TabIndex = 9;
            this.mInferSelected.Text = "Infer Selected";
            this.mInferSelected.UseVisualStyleBackColor = true;
            this.mInferSelected.Click += new System.EventHandler(this.mInferSelected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 343);
            this.Controls.Add(this.mInferSelected);
            this.Controls.Add(this.mSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id3TagInfoTable);
            this.Controls.Add(this.mMagic);
            this.Controls.Add(this.tableInferred);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AutoID3Tagger";
            ((System.ComponentModel.ISupportInitialize)(this.tableInferred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id3TagInfoTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tableInferred;
        private System.Windows.Forms.Button mMagic;
        private System.Windows.Forms.DataGridView id3TagInfoTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mSave;
        private System.Windows.Forms.Button mInferSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn mArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFeatList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

