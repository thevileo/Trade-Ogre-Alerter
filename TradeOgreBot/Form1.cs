using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.Exceptions;
using Tulpep.NotificationWindow;
using System.Media;
using System.IO;
using System.Security.AccessControl;
using System.Text;
using System.Collections.Specialized;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Linq;
using Authenticate;

namespace TradeOgreBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; //TLS 1.2


            // Load Crypto names into drop down boxe.
            var client = new WebClient();
            var json = client.DownloadString("https://tradeogre.com/api/v1/markets");
            dynamic root = JArray.Parse(json);

            foreach (JObject o in root.Children<JObject>())
            {
                foreach (JProperty p in o.Properties())
                {
                    string name = p.Name;
                    cryptoBox1.Items.Add(name);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //Check if files exist, if not create them:
            if (!File.Exists("valueStored.txt") || !File.Exists("valueStored2.txt"))
            {
                var valueStored = File.Create("valueStored.txt");
                var valueStored2 = File.Create("valueStored2.txt");
                valueStored.Close();
                valueStored2.Close();
            }
            //Read the Files
            else
            {
                string valueBoxSet1;
                using (var greaterLessBox1 = new StreamReader("valueStored.txt"))
                {
                    greaterLessEqualComboBox.Text = greaterLessBox1.ReadLine(); // Criteria 1 Storage
                    valueStoredTextBox.Text = valueBoxSet1 = greaterLessBox1.ReadLine(); //criteria1 2 Storage

                }

                string valueBoxSet2;
                using (var greaterLessBox2 = new StreamReader("valueStored2.txt"))
                {
                    greaterLessEqualComboBox2.Text = greaterLessBox2.ReadLine(); // Criteria 1 Storage
                    valueStoredTextBox2.Text = valueBoxSet2 = greaterLessBox2.ReadLine(); //criteria1 2 Storage

                }
                
            }
            //Read API File
            if (!File.Exists("apiKey.txt"))
            {
                var valueStored = File.Create("apiKey.txt");
                valueStored.Close();
            }
            //Read Secret Key File
            if (!File.Exists("secretKey.txt"))
            {
                var valueStored = File.Create("secretKey.txt");
                valueStored.Close();
            }

 

        }


        private void cryptoBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();

        }
        #region My_Methods
        public void LoadData()
        {

            //Load Data start
            var client = new WebClient();
            var json = client.DownloadString("https://tradeogre.com/api/v1/markets");
            var pumps = client.DownloadString("https://tradeogre.com/api/v1/history/" + cryptoBox1.Text);
            dynamic root = JArray.Parse(json);
            dynamic pumpRoot = JArray.Parse(pumps);

            foreach (JObject o in root.Children<JObject>())
            {
                foreach (JProperty p in o.Properties())
                {
                    if (cryptoBox1.SelectedItem.ToString() == cryptoBox1.SelectedItem.ToString() && p.Name == cryptoBox1.SelectedItem.ToString())
                    {


                        string name = p.Name;

                        string initialprice = Convert.ToString(p.Value.First);
                        initialprice = Regex.Replace(initialprice, @"[A-Za-z"""":]+", "");
                        intialPriceLabelOutput.Text = initialprice;

                        string price = Convert.ToString(p.Value.First.Next);
                        price = Regex.Replace(price, @"[A-Za-z"""":]+", "");
                        currentPriceLabelOutput.Text = price;

                        string volume = Convert.ToString(p.Value.First.Next.Next.Next.Next);
                        volume = Regex.Replace(volume, @"[A-Za-z"""":]+", "");
                        volumeOutputLabel.Text = volume;

                        string ask = Convert.ToString(p.Value.First.Next.Next.Next.Next.Next.Next);
                        ask = Regex.Replace(ask, @"[A-Za-z"""":]+", "");
                        currentAskLabelOutput.Text = ask;

                        string bid = Convert.ToString(p.Value.First.Next.Next.Next.Next.Next);
                        bid = Regex.Replace(bid, @"[A-Za-z"""":]+", "");
                        currentBidLabelOutput.Text = bid;


                    }
                }
            }

            //Subtract listing price from current price and highlight based off reulsts 
            decimal initialPrice;
            decimal currentPrice;
            if (Decimal.TryParse(intialPriceLabelOutput.Text, out initialPrice) && Decimal.TryParse(currentPriceLabelOutput.Text, out currentPrice))
            {

                if (currentPrice > initialPrice)
                {
                    suggestionLabelOutput.Text = "SELL!";
                    suggestionLabelOutput.ForeColor = System.Drawing.Color.Red;
                }


                else if (currentPrice <= Convert.ToDecimal(0.9) * initialPrice)
                {
                    suggestionLabelOutput.Text = "STRONG BUY!";
                    suggestionLabelOutput.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    suggestionLabelOutput.Text = "BUY!";
                    suggestionLabelOutput.ForeColor = System.Drawing.Color.Green;
                }
            }
    ;





        }
        private void TimetoSell()
        {
            if (autoAlertsCheckBox.Checked == true)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                simpleSound.Play();
            }
            if (desktopAlertsCheckBox.Checked == true)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Time To Sell!!";
                popup.ContentText = "Its time to Sell your " + cryptoBox1.Text + " !";
                popup.Popup();// show  
            }
            if (smsAlertsCheckBox.Checked == true)
            {
                TextAlertSELL();
            }
        }
        private void TimetoBuy()
        {
            if (autoAlertsCheckBox.Checked == true)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                simpleSound.Play();
            }
            if (desktopAlertsCheckBox.Checked == true)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Time To BUY!!";
                popup.ContentText = "Its time to BUY your " + cryptoBox1.Text + " !";
                popup.Popup();// show  
            }
            if (smsAlertsCheckBox.Checked == true)
            {
                TextAlertBUY();
            }
        }
        private void TextAlertSELL()
        {
            // Use your account SID and authentication token instead
            // of the placeholders shown here.
            AuthKeys auth = new AuthKeys();

            string accountSID = auth.apiKey;
            string authToken = auth.secretKey;

            // Initialize the TwilioClient.
            TwilioClient.Init(accountSID, authToken);

            try
            {
                // Send an SMS message.
                var message = MessageResource.Create(
                    to: new PhoneNumber("+12153174085"),
                    from: new PhoneNumber("+14158552279"),
                    body: "Time to Sell " + cryptoBox1.Text + " ! Current Bid is  " + greaterLessEqualComboBox.Text + " " + valueStoredTextBox.Text);
               smsAlertsCheckBox.Checked = false;
                  Console.WriteLine("Success!");
            }
            catch (TwilioException ex)
            {
                // An exception occurred making the REST call
                // Console.WriteLine(ex.Message);
                smsAlertsCheckBox.Checked = false;
                MessageBox.Show("Please verify your Twilio Keys in the Settings. SMS alerts are now disabled, retry when keys are correct!");
            }
        }
        private void TextAlertBUY()
        {
            // Use your account SID and authentication token instead
            // of the placeholders shown here.
            AuthKeys auth = new AuthKeys();

            string accountSID = auth.apiKey;
            string authToken = auth.secretKey;

            // Initialize the TwilioClient.
            TwilioClient.Init(accountSID, authToken);

            try
            {
                // Send an SMS message.
                var message = MessageResource.Create(
                    to: new PhoneNumber("+12153174085"),
                    from: new PhoneNumber("+14158552279"),
                    body: "Time to BUY " + cryptoBox1.Text + " ! Current Bid is  " + greaterLessEqualComboBox.Text + " " + valueStoredTextBox.Text);
                smsAlertsCheckBox.Checked = false;
                Console.WriteLine("Success!");
            }
            catch (TwilioException ex)
            {
                // An exception occurred making the REST call
                // Console.WriteLine(ex.Message);
                smsAlertsCheckBox.Checked = false;
                MessageBox.Show("Please verify your Twilio Keys in the Settings. SMS alerts are now disabled, retry when keys are correct!");
            }
        }

        #endregion
        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {

            decimal setPrice;
            decimal bidPrice;
            timer1.Interval = Convert.ToInt32(delayComboBox.Text);
            LoadData();

            #region SellCheckBoxEnabled
            if (sellAlertcheckBox.Checked == true && greaterLessEqualComboBox.Text == ">=")
            {
                if (Decimal.TryParse(currentBidLabelOutput.Text, out bidPrice) && Decimal.TryParse(valueStoredTextBox.Text, out setPrice))
                {

                    if (bidPrice >= setPrice)
                    {
                        TimetoSell();
                    }
                }
            }

                if (sellAlertcheckBox.Checked == true && greaterLessEqualComboBox.Text == "<=")
                {
                    if (Decimal.TryParse(currentBidLabelOutput.Text, out bidPrice) && Decimal.TryParse(valueStoredTextBox.Text, out setPrice))
                    {

                        if (bidPrice <= setPrice)
                        {
                            TimetoSell();
                        }
                    }

                }
            
            #endregion


            decimal setPrice2;
            decimal askPrice;
            #region BuyCheckBoxEnabled
            if (buyAlertCheckBox.Checked == true && greaterLessEqualComboBox2.Text == ">=")
            {
                if (Decimal.TryParse(currentAskLabelOutput.Text, out askPrice) && Decimal.TryParse(valueStoredTextBox2.Text, out setPrice2))
                {

                    if (askPrice >= setPrice2)
                    {
                        TimetoBuy();
                    }
                }
            }

                if (buyAlertCheckBox.Checked == true && greaterLessEqualComboBox2.Text == "<=")
                {
                    if (Decimal.TryParse(currentAskLabelOutput.Text, out askPrice) && Decimal.TryParse(valueStoredTextBox2.Text, out setPrice2))
                    {

                        if (askPrice <= setPrice2)
                        {
                            TimetoBuy();
                        }
                    }

                }
            
            #endregion

        }
        #endregion
        #region Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            //Fail Safe that both checkboxes are not enabled before starting
            if (sellAlertcheckBox.Checked == true && buyAlertCheckBox.Checked == true)
            {
                MessageBox.Show("Only 1 Buy or Sell alert checkbox can be enabled at a time, please go back and deselect one.","Review Filters");
            }
            else
            {

                if (startButton.Text == "Stop")
                {

                    startButton.Text = "Start";
                    timer1.Enabled = false;
                }
                else
                {

                    startButton.Text = "Stop";
                    timer1.Enabled = true;
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
           

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Get Balances
            string site = "https://tradeogre.com/api/v1/account/orders";
            RestClient rClient = new RestClient();
            AuthKeys aKeys = new AuthKeys();
            rClient.endPoint = site;
            rClient.authTech = autheticationTechnique.RollYourOwn;
            rClient.authType = authenticationType.Basic;
            rClient.userName = aKeys.apiKey;
            rClient.userPassword = aKeys.secretKey;
            rClient.httpMethod = httpVerb.POST;
            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();
            Console.WriteLine(strResponse);

        }
        private void valueStoredButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("valueStored.txt", greaterLessEqualComboBox.Text + Environment.NewLine + valueStoredTextBox.Text);
        }
        #endregion
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings myNewForm = new Settings();
            myNewForm.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twilio.com/referral/1cmlQq");
        }

        private void buyAlertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (buyAlertCheckBox.Checked == true)
            {
                sellAlertcheckBox.Enabled = false;
                panel1.Enabled = false;
                alertCriteriaLabel.Enabled = false;
                greaterLessEqualComboBox.Enabled = false;
                valueStoredTextBox.Enabled = false;
                valueStoredButton.Enabled = false;

            }
            if (buyAlertCheckBox.Checked == false)
                {
                sellAlertcheckBox.Enabled = true;
                panel1.Enabled = true;
                alertCriteriaLabel.Enabled = true;
                greaterLessEqualComboBox.Enabled = true;
                valueStoredTextBox.Enabled = true;
                valueStoredButton.Enabled = true;
            }

        }

        private void sellAlertcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sellAlertcheckBox.Checked == true)
            {
                buyAlertCheckBox.Enabled = false;
                panel2.Enabled = false;
                label2.Enabled = false;
                greaterLessEqualComboBox2.Enabled = false;
                valueStoredTextBox2.Enabled = false;
                button1.Enabled = false;
            }
            if (sellAlertcheckBox.Checked == false)
            {
                buyAlertCheckBox.Enabled = true;
                panel2.Enabled = true;
                label2.Enabled = true;
                greaterLessEqualComboBox2.Enabled = true;
                valueStoredTextBox2.Enabled = true;
                button1.Enabled = true;
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            File.WriteAllText("valueStored2.txt", greaterLessEqualComboBox2.Text + Environment.NewLine + valueStoredTextBox2.Text);


           
        }
    }
}


   
