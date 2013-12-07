/* 
 
Easy Hash - Simple Plain-text to Hash Generator 
Copyright (C) 2013 Calvin Hartwell 

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA. 

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography; // Used for Hash Algorithms 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyhash
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set the first hash algorithm as the currently selected 
            cbAlgorithms.SelectedIndex = 0; 
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Quit application 
            this.Close(); 
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Put the generated Hash on the clip board 
            Clipboard.SetDataObject(this.tbHashOutput.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the text boxes (generated hash and plain text) 
            this.tbHashOutput.Clear();
            this.tbPlainText.Clear(); 
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Used to build the hash output 
            StringBuilder sBuilder = new StringBuilder();

            // Get the plain text from the user 
            String input = this.tbPlainText.Text;
            
            // Will hold the bytes of the encoded hash 
            byte[] data; 

            // Generate the hash based on the algorithm selection 
            switch(cbAlgorithms.Items[cbAlgorithms.SelectedIndex].ToString()) {
                case "MD5":
                       MD5 md5Hash = MD5.Create();
                       data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                       for (int i = 0; i < data.Length; i++)
                       {
                           sBuilder.Append(data[i].ToString("x2"));
                       }  
                    break; 

               case "SHA1":
                      SHA1 sha = new SHA1CryptoServiceProvider();
                      data = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                      for (int i = 0; i < data.Length; i++)
                      {
                          sBuilder.Append(data[i].ToString("x2"));
                      }
                    break;
                      
               case "SHA256":
                      SHA256 sha256 = new SHA256CryptoServiceProvider();
                      data = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                      for (int i = 0; i < data.Length; i++)
                      {
                          sBuilder.Append(data[i].ToString("x2"));
                      }
                    break; 
                      
                case "SHA384":
                      SHA384 sha384 = new SHA384CryptoServiceProvider();
                      data = sha384.ComputeHash(Encoding.UTF8.GetBytes(input));
                      for (int i = 0; i < data.Length; i++)
                      {
                          sBuilder.Append(data[i].ToString("x2"));
                      }
                    break; 
                      
                case "SHA512":
                      SHA512 sha512 = new SHA512CryptoServiceProvider();
                      data = sha512.ComputeHash(Encoding.UTF8.GetBytes(input));
                      for (int i = 0; i < data.Length; i++)
                      {
                          sBuilder.Append(data[i].ToString("x2"));
                      }
                    break; 
                       
                case "Base 64":
                    data = Encoding.UTF8.GetBytes(this.tbPlainText.Text);
                    sBuilder.Append(Convert.ToBase64String (data));
                    break; 

                default:
                    MessageBox.Show("Error: Unknown Algorithm Selected, cannot compute!");
                    break; 
            }


            // Display the hash output 
            this.tbHashOutput.Text = sBuilder.ToString(); 
        }
    }
}
