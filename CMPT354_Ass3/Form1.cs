using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPT354_Ass3
{
    public partial class Start_Form : Form
    {
        SqlConnection objconn = new SqlConnection("Data Source=cypress.csil.sfu.ca;" + "Initial Catalog=dca29354;" + "Trusted_Connection=Yes;" + "User ID=s_dca29;" + "Password=naRHYgAQ2YnJ7gM3");
        SqlDataReader reader;
        
        public Start_Form()
        {
            InitializeComponent();
            SearchTerm_Combo.SelectedIndex = 0;
            SID_Text.Focus();
        }

        public void release_Usedtable(DataTable dt)
        {
            dt.Dispose();
        }


        private void Login_Button_Click(object sender, EventArgs e)
        {
            string ID = this.SID_Text.Text;
            string PW = this.SPW_Text.Text;

            if (ID == "" || PW == "")
            {
                MessageBox.Show("Please enter your Student Number and Password Correctly");
                SID_Text.Focus();
            }
            else
            {
                try
                {
                    objconn.Open();
                    string logQuery = "SELECT s.Student_no, s.Student_PW, s.FirstName, s.LastName, d.Depart_Name FROM Student_info s " +
                                  "inner join Depart_info d ON (s.Depart_ID = d.Depart_ID) " +
                                  "WHERE s.Student_no = '" + ID + "' and Student_PW = '" + PW + "'";
                    SqlCommand logCmd = new SqlCommand(logQuery, objconn);

                    reader = logCmd.ExecuteReader();





                    if (reader.Read())
                    {
                        string FN = reader["FirstName"].ToString();
                        string LN = reader["LastName"].ToString();
                        MessageBox.Show("Welcome " + FN + "!");

                        Register1_Form f2 = new Register1_Form();
                        f2.Show();
                        f2.SID_Text.Text = reader["Student_no"].ToString();
                        f2.SN_Text.Text = FN + " " + LN;
                        f2.SD_Text.Text = reader["Depart_Name"].ToString();

                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid ID or Password. Please Enter again.");
                    }
                    objconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            searchForm sf = new searchForm();
            sf.Show();

        }
    }
}
