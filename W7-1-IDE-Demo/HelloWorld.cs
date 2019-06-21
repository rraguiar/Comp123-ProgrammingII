using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W7_1_IDE_Demo
{
    public partial class HelloWorld : Form
    {
        private float m_randomNumber;

        public HelloWorld()
        {
            InitializeComponent();
            Start();
        }
        /* <sumary>
         * This method is used for initialization purposes
         * </sumary>
         */
        public void Start()
        {
            //Hello World label
            HelloWorldLabel.Text = "Hello, Rafael!";
            HelloWorldLabel.BackColor = Color.Black;
            HelloWorldLabel.ForeColor = Color.White;

            AddRandomNumberToRandomNumberLabel();

        }

        /// <summary>
        /// Event Handler for the ClickMeButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = (HelloWorldLabel.Text == "Hello, Rafael!") ? "Clicked!" : "Hello, Rafael!";
            AddRandomNumberToRandomNumberLabel();


            //if (HelloWorldLabel.Text == "Hello, Rafael!")
            //    HelloWorldLabel.Text = "Clicked!";
            //else
            //    HelloWorldLabel.Text = "Hello, Rafael!";
        }

        /// <summary>
        /// This method adds a random number from 1 to 49 to the RandomNumberLabel text property.
        /// </summary>
        private void AddRandomNumberToRandomNumberLabel()
        {
            //RandomNumberLabel
            this.m_randomNumber = new Random().Next(0, 49) + 1;
            RandomNumberLabel.Text = m_randomNumber.ToString();
        }
    }
}
