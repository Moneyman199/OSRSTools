using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace OSRSTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        public List<MultiList> bestTime = new List<MultiList>();


        //enable/disable the textbox depending if the corresponding radio button is checked
        private void specificRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (specificWorldTextbox.Enabled == true)
            {
                specificWorldTextbox.Clear();
                specificWorldTextbox.Enabled = false;
            }
            else
            {
                specificWorldTextbox.Enabled = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Reset();
            //allRadioButton.Enabled = true;
        }

        private void Reset()
        {
            resultsView.Items.Clear();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsView.Items.Clear();

            int world = 0;

            if (specificRadioButton.Checked == true)
            {
                if (!Int32.TryParse(specificWorldTextbox.Text, out world))
                {
                    MessageBox.Show("The value entered must be a whole, non-negative number");
                }
            }

            BeginPing(world);
        }

        private void BeginPing(int world)
        {
            bestTime.Clear();

            List<string> serverList = new List<string>();

            if (world == 0)
            {
                for (int i = 1; i <= 99; i++)
                {
                    serverList.Add("oldschool" + i + ".runescape.com");
                }
            }
            else
            {
                serverList.Add("oldschool" + world + ".runescape.com"); //make sure the world variable is not beginning with 3 (ie, w372 should be 72)
            }

            foreach (string server in serverList)
            {
                GetPing(server);
            }

            //resultsView = bestTime;


            if (orderRadioButton.Checked == true || topWorldsRadioButton.Checked == true)
            {
                //bestTime.Sort((x, y) => string.Compare(x.ResponseTime.ToString(), y.Server.ToString()));
                var orderedList = bestTime.OrderBy(x => x.ResponseTime).ThenBy(x => x.Server);

                foreach (var item in orderedList)
                {
                    resultsView.Items.Add(new ListViewItem(new string[] { item.Server, item.ResponseTime.ToString() }));
                }
            }
            else
            {
                foreach (var item in bestTime)
                {
                    resultsView.Items.Add(new ListViewItem(new string[] { item.Server, item.ResponseTime.ToString() }));
                }
            }
                

            
        }

        private void GetPing(string IP)
        {
            long minResponse = 5000;

            for (int i = 1; i<= 1; i++) //incase i want to get best of x attempts
            {
                try
                {
                    long responseTime;
                    Ping myPing = new Ping();
                    PingReply reply = myPing.Send(IP, 1000); //1 second timeout
                    responseTime = reply.RoundtripTime;

                    if (responseTime < minResponse && responseTime != 0)
                    {
                        minResponse = responseTime;
                    }
                }
                catch 
                {
                    continue; //if world does not exist, wont break program
                }
            }
            if (minResponse != 5000 && minResponse != 0) //server was not able to be pinged
            {
                bestTime.Add(new MultiList { Server = IP, ResponseTime = minResponse });
            }
        }



    }
}
