using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ViewFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            locationTextBox.Text = ofd.FileName;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    TextReader tr = new StreamReader(locationTextBox.Text);
                    displayTextBox.Text = tr.ReadToEnd();
                }
                catch (System.ArgumentException ex)
                {
                    MessageBox.Show("������ ��� ���� ��� �� ���� �����! (c) ���������");
                }
                finally {
                    // Close();
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("���� �� ������! ������� (c) ����");
            }
        }

        private void displayTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}