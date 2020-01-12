using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtcoDataLibrary;

namespace ATCOClient
{
    public partial class Form1 : Form
    {
        ATCCenter ATC;
        public Form1()
        {
            InitializeComponent();
            ATC = new ATCCenter();
            listBoxATCOs.DisplayMember = "Name";

            
            foreach (var item in ATC.GetEmployees())
            {
                listBoxATCOs.Items.Add(item);
            }


        }

        private void addATCO_Click(object sender, EventArgs e)
        {
            ATCO atco = new ATCO(int.Parse(textBoxCertID.Text), int.Parse(textBoxID.Text), textBoxName.Text);
            ATC.AddEmployee(atco);

            listBoxATCOs.Items.Clear();
            foreach (var item in ATC.GetEmployees())
            {
                listBoxATCOs.Items.Add(item);
            }

            
            textBoxCertID.Text = "";
            textBoxID.Text = "";
            textBoxName.Text = "";

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ATCO atco = (ATCO)listBoxATCOs.SelectedItem;

            atco.RegisterHours(double.Parse(textBoxHours.Text), dateTimePicker.Value);

            label7.Text = $"name: {atco.Name} hours: {textBoxHours.Text} on date {dateTimePicker.Value} ";
        }
    }
}
