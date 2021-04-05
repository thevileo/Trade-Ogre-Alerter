using System;
using System.IO;
using System.Windows.Forms;

namespace TradeOgreBot
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            if (!File.Exists("apiKey.txt") || !File.Exists("secretKey.txt") || !File.Exists("valueStored.txt"))
            {
                var api = File.Create("apiKey.txt");
                var secrert = File.Create("secretKey.txt");
                api.Close();
                secrert.Close();
            }
            else
            {
                tradeOgreApiTextBox.Text = File.ReadAllText("apiKey.txt").ToString();
                secretTextBox.Text = File.ReadAllText("secretKey.txt").ToString();
             
            }
        }
        // Encrypt a file.
        public static void AddEncryption(string FileName)
        {

            File.Encrypt(FileName);
        }

        // Decrypt a file.
        public static void RemoveEncryption(string FileName)
        {
            File.Decrypt(FileName);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {

#region API Key Box
            File.WriteAllText("apiKey.txt", tradeOgreApiTextBox.Text);

            if (tradeOgreApiTextBox.Text != null)
            {
                try
                {

                    string FileName = "apiKey.txt";


                    // Encrypt the file.
                    AddEncryption(FileName);

                    // Decrypt the file.
                    //  RemoveEncryption(FileName);


                }
                catch
                {
                    Console.WriteLine("FAILED");
                }

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Key already entered");
            }
            #endregion

#region Secret Key Box

            File.WriteAllText("secretKey.txt", secretTextBox.Text);

            if (secretTextBox.Text != null)
            {
                try
                {

                    string FileName = "secretKey.txt";


                    // Encrypt the file.
                    AddEncryption(FileName);

                    // Decrypt the file.
                    //  RemoveEncryption(FileName);


                }
                catch
                {
                    Console.WriteLine("FAILED");
                }

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Key already entered");
            }
            #endregion
            MessageBox.Show("Settings Saved!");
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
                // Display a MsgBox asking the user to save changes or abort.
                if (MessageBox.Show("Settings were not saved! Are you sure you want to exit settings?", "Settings",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = false;
                    // Call method to save file...
                }
                else
            { e.Cancel = true; }
            }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
    }

