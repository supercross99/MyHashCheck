using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace MyHashCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Computing Hash!";
            string filePath = @"E:\Downloads\BBB-eMMC-flasher-debian-7.5-2014-05-14-2gb.img\BBB-eMMC-flasher-debian-7.5-2014-05-14-2gb.img";

            FileStream filestream;
            SHA256 mySHA256 = SHA256Managed.Create();
            MD5 myMD5 = MD5.Create();

            filestream = new FileStream(filePath, FileMode.Open);

            filestream.Position = 0;

            //byte[] hashValue = mySHA256.ComputeHash(filestream);
            byte[] hashValue = myMD5.ComputeHash(filestream);

            label1.Text = BitConverter.ToString(hashValue).Replace("-", String.Empty);

            filestream.Close();

        }
    }
}
