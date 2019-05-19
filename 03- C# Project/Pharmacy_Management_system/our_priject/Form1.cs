using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace our_priject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("You Sure to exit", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Doctor = new Form2();
            Doctor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 GP = new Form3();
            GP.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 Patient = new Form4();
            Patient.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 Payment = new Form5();
            Payment.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 Parmacy = new Form6();
            Parmacy.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 Phar_Office = new Form7();
            Phar_Office.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "ahmed" && txtPassword.Text =="1234")
            {
                btnDoctor.Enabled = true;
                btnPatient.Enabled = true;
                btnGP.Enabled = true;
                btnPayment.Enabled = true;
                btnPharmacey.Enabled = true;
                btnPhar_Office.Enabled = true;
               // btnConsultant.Enabled = true;
                btnHelp.Enabled = true;
               /* btnSpecialist.Enabled = true;
                btnSurgery.Enabled = true;
                btnHospital.Enabled = true;
                btnPharmacircle.Enabled = true;
                btnPharmacist.Enabled = true;*/
                btnLogOut.Enabled = true;
                btnLogin.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please Enter Correct Login Details", "Pharmacy Management System");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogOut.Enabled = false;
            btnDoctor.Enabled = false;
            btnPatient.Enabled = false;
            btnGP.Enabled = false;
            btnPayment.Enabled = false;
            btnPharmacey.Enabled = false;
            btnPhar_Office.Enabled = false;
           // btnConsultant.Enabled = false;
            btnHelp.Enabled = false;
           /* btnSpecialist.Enabled = false;
            btnSurgery.Enabled = false;
            btnHospital.Enabled = false;
            btnPharmacircle.Enabled = false;
            btnPharmacist.Enabled = false;*/
          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            btnDoctor.Enabled = false;
            btnPatient.Enabled = false;
            btnGP.Enabled = false;
            btnPayment.Enabled = false;
            btnPharmacey.Enabled = false;
            btnPhar_Office.Enabled = false;
           // btnConsultant.Enabled = false;
            btnHelp.Enabled = false;
           /* btnSpecialist.Enabled = false;
            btnSurgery.Enabled = false;
            btnHospital.Enabled = false;
            btnPharmacircle.Enabled = false;
            btnPharmacist.Enabled = false;*/
            btnLogin.Enabled = true;
            btnLogOut.Enabled = false;
        }
    }
}
