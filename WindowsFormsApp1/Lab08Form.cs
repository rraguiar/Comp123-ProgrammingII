using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Lab08Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// This is the default constructor
        /// </summary>

        public Lab08Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event Handler for the AgeTextBox for the TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// This is the Event Handler for the SubmitButton Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
            /*
            //Option A
            UserAge = Convert.ToSingle(AgeTextBox.Text);
            */
            //Option B
            UserAge = float.Parse(AgeTextBox.Text);
            /*
            //Option C
            float tempFloat;
            bool result = float.TryParse(AgeTextBox.Text, out tempFloat);
            UserAge = tempFloat;
            */

            OutputLabel.Text = NameTextBox.Text + "" + AgeTextBox.Text;
            ClearForm();
        }

        /// <summary>
        /// This method Clears the form prior to user´s use
        /// </summary>
        private void ClearForm()
        {
            ClearFields();
            SubmitButton.Enabled = false;

        }

        /// <summary>
        /// This clears the Fields before user´s fulfill.
        /// </summary>
        private void ClearFields()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
        }

        /// <summary>
        /// Checks if Age is number and handle the exception
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch
            {
                SubmitButton.Enabled = false;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameLabel.Text.Length >= 2)?true:false;
        }
    }
}
