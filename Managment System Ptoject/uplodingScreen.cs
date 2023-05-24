using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managment_System_Ptoject
{
    public partial class uplodingScreen : Form
    {
        public uplodingScreen()
        {
            InitializeComponent();
            progressBarTimer.Start();//start the timer called progressBarTimer
        }

        private void progressBarTimer_Tick(object sender, EventArgs e)//event - what happend every tick
        {
            loadingBar.Increment(5); // increase the loading bar by 5
            progressBarLabel.Text = loadingBar.Value + "%";
            if (loadingBar.Value == 100)
            {
                progressBarTimer.Stop();
                this.Hide();
                LoginScreen login = new LoginScreen(); //if the progressBar get to 100, stop the timer, go to the login screen
                login.Show();
            }
        }
    }
}
