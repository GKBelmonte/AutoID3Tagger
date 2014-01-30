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
        public Form1()
        {
            InitializeComponent();
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
            try
            {
                List<string> list =  (List<string>) Directory.EnumerateFiles(this.textBox1.Text);
                foreach (string item in list)
                {
                    string[] stuff = item.Split(new char[] { '-'});
                    string artist;
                    string album;
                    string song;
                    //string supporting;
                    if (stuff.Length == 3)
                    {
                        artist = stuff[0];
                        album = stuff[1];
                        song = stuff[2];
                    }
                    else if (stuff.Length == 2)
                    {
                        artist = stuff[0];
                        album = stuff[0];
                        song = stuff[1];
                    }
                    else if (stuff.Length == 1)
                    {
                        artist = stuff[0];
                        album = stuff[0];
                        song = stuff[0];
                    }

                    var row = new DataGridViewRow();
                    this.dataGridView1.Rows.Add(new DataGridViewRow());
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException err)
            {
                MessageBox.Show("Argument shit happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(IOException err)
            {
                MessageBox.Show("Some other IO exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
