using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoID3Tagger
{
    public partial class Form1 : Form
    {
        int mOldHeight;
        public Form1()
        {
            InitializeComponent();
            this.SizeChanged += Form1_SizeChanged;
            mOldHeight = this.Height;
        }

        void Form1_SizeChanged(object sender, EventArgs e)
        {
            var delta = Height - mOldHeight;
            id3TagInfoTable.Height += delta;
            tableInferred.Height += delta;
            mOldHeight = Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new FolderBrowserDialog();
            DialogResult y = x.ShowDialog();
            if (y == DialogResult.OK)
            {
                this.textBox1.Text = x.SelectedPath;
            }
        }

        private void mMagic_Click(object sender, EventArgs e)
        {
            tableInferred.Rows.Clear();
            id3TagInfoTable.Rows.Clear();
            try
            {
                IEnumerable<string> list =  Directory.EnumerateFiles(this.textBox1.Text);
                
                foreach (string item in list)
                {
                    string fileName = Path.GetFileNameWithoutExtension(item);
                    string[] stuff = fileName.Split(new char[] { '-' });
                    string artist;
                    string album;
                    string song;
                    string supArts = string.Empty;
                    
                    //string supporting;
                    if (stuff.Length == 3)
                    {
                        artist = stuff[0].Trim();
                        album = stuff[1].Trim();
                        song = stuff[2].Trim();
                    }
                    else if (stuff.Length == 2)
                    {
                        artist = stuff[0].Trim();
                        album = stuff[0].Trim();
                        song = stuff[1].Trim();
                    }
                    else if (stuff.Length == 1)
                    {
                        artist = stuff[0].Trim();
                        album = stuff[0].Trim();
                        song = stuff[0].Trim();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect format for " + item, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    var featSplit =  song.Split(new string[]  { "ft."} , StringSplitOptions.None );;
                    song = featSplit[0].Trim();
                    if (featSplit.Length > 1)
                    {
                        supArts = featSplit[1].Trim();
                    }

                    var row = new DataGridViewRow();
                    row.Tag = item;
                    row.CreateCells(tableInferred, artist, album, song, supArts);
                    this.tableInferred.Rows.Add(row);

                    /*Read info from tags*/
                    string id3Artist;
                    string id3Album;
                    string id3SongName;
                    string id3SupArtist;
                    
                    TagLib.File info = TagLib.File.Create(item);
                    id3Artist = info.Tag.FirstAlbumArtist != null? info.Tag.FirstAlbumArtist.Trim(): "";
                    id3Album = info.Tag.Album != null? info.Tag.Album.Trim() : "";
                    id3SongName = info.Tag.Title != null ? info.Tag.Title.Trim() : "";
                    var allArts = info.Tag.AlbumArtists != null ? info.Tag.AlbumArtists.ToList() : new List<string>(0);
                    if(allArts.Count >= 1)
                        allArts.RemoveAt(0);
                    id3SupArtist = string.Join(";" , allArts.ToArray());

                    var nowRow = new DataGridViewRow();
                    nowRow.Tag = item;
                    nowRow.CreateCells(this.id3TagInfoTable, id3Artist, id3Album, id3SongName, id3SupArtist);
                    this.id3TagInfoTable.Rows.Add(nowRow);
                    info.Dispose();

                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException err)
            {
                MessageBox.Show("Argument Exception Happened: \n"+ err.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(IOException err)
            {
                MessageBox.Show("Some other IO exception: \n" + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mInferSelected_Click(object sender, EventArgs e)
        {
            var rows = tableInferred.SelectedRows;
            if (rows.Count == 0)
            {
                MessageBox.Show("No rows selected. Make sure to select the row, not the cell.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (DataGridViewRow row in rows)
            {
                var otherRows = id3TagInfoTable.Rows;
                DataGridViewRow match = null;
                //find the corresponding row
                foreach (DataGridViewRow oRow in otherRows)
                {
                    if (oRow.Tag == row.Tag)
                    {
                        match = oRow;
                        break;
                    }
                }

                for (var ii = 0; ii < 4; ii++ )
                {
                    match.Cells[ii].Value = row.Cells[ii].Value;
                }
            }
        }

        private void mSave_Click(object sender, EventArgs e)
        {
            var rows = id3TagInfoTable.SelectedRows;
            if (rows.Count == 0)
            {
                MessageBox.Show("No rows selected. Make sure to select the row, not the cell.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in rows)
            {
                TagLib.File file = TagLib.File.Create((string)row.Tag);
                string[] artistArr = ((string)row.Cells[3].Value).Split(new char[] {';'},StringSplitOptions.RemoveEmptyEntries);
                List<string> artistList = new List<string>(artistArr.Length + 1);
                artistList.Add((string)row.Cells[1].Value);
                artistList.AddRange( artistArr  );

                
                file.Tag.Album = (string)row.Cells[1].Value;
                file.Tag.Title = (string)row.Cells[2].Value;
                
                file.Tag.AlbumArtists = null;
                file.Tag.AlbumArtists = artistList.ToArray();
                //file.Tag.Performers = artistList.ToArray();
                file.Save();
                file.Dispose();
            }

            MessageBox.Show("Selected Rows saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





    }
}
