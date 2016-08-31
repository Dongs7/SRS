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

    public partial class Register1_Form : Form
    {

        Start_Form f1 = new Start_Form();
        SqlConnection objconn = new SqlConnection("Data Source=cypress.csil.sfu.ca;" + "Initial Catalog=dca29354;" + "Trusted_Connection=Yes;" + "User ID=s_dca29;" + "Password=naRHYgAQ2YnJ7gM3");
        SqlDataReader reader;
        string NumSearch, lvlSearch, deptSearch, currentUser, selectedID, prereqResult, dupResult, currentUserID;
        int creditResult;

        private void fillCombo()
        {
            string fillQuery = " SELECT DISTINCT (depart_ID +' '+ depart_Name) as department FROM depart_info;";
            SqlCommand fillConn = new SqlCommand(fillQuery, objconn);
            objconn.Open();
            reader = fillConn.ExecuteReader();

            while (reader.Read())
            {
                string courses = reader["department"].ToString();
                depart_combo.Items.Add(courses);
            }
            reader.Close();
            objconn.Close();
        }
        private void finalGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (finalGrid.RowCount > 0)
            {
                selectedID = finalGrid.SelectedRows[0].Cells["CRSID"].Value.ToString();
            }

        }
        private void searchGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = searchGrid.SelectedRows[0].Cells["ID"].Value.ToString();
            prereqResult = searchGrid.SelectedRows[0].Cells["Pre"].Value.ToString();
        }
        public void data_To_fill(SqlDataAdapter s)
        {
            DataTable data = new DataTable();
            s.Fill(data);
        }
        public void data_To_Grid(SqlDataAdapter s, DataGridView dgv)
        {
            DataTable data = new DataTable();
            s.Fill(data);
            dgv.DataSource = data;
        }
        public void dataGrid_Empty(DataGridView dgv)
        {
            DataTable data = new DataTable();
            data = null;
            dgv.DataSource = data;
        }
        public Register1_Form()
        {
            InitializeComponent();
            fillCombo();
            term_combo.SelectedIndex = 0;
            depart_combo.SelectedIndex = 0;
            level_combo.SelectedIndex = 0;
            currentUserID = SID_Text.Text;
        }
        private void reset_button_Click(object sender, EventArgs e)
        {
            term_combo.SelectedIndex = 0;
            depart_combo.SelectedIndex = 0;
            level_combo.SelectedIndex = 0;
            dataGrid_Empty(searchGrid);
            numberSearch.Text = "Please enter Crs Number";
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            currentUser = SN_Text.Text;
            DialogResult = MessageBox.Show("Do you want to Logout, " + currentUser + " ?", "Log Out", MessageBoxButtons.YesNo);
            if (DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                objconn.Dispose();
                Start_Form f1 = new Start_Form();
                f1.Show();
                this.Close();
            }
            else
            {
            }
        }
        private void numberSearch_MouseClick(object sender, MouseEventArgs e)
        {
            numberSearch.Clear();
        }

       
        private void searchCrs_button_Click(object sender, EventArgs e)
        {
            
            NumSearch = numberSearch.Text;
            lvlSearch = Convert.ToString(level_combo.SelectedItem).Substring(0, 4);
            deptSearch = Convert.ToString(depart_combo.SelectedItem).Substring(0, 2);

            #region Searching Queries
            string searchQry1 = "select c.course_id as 'ID' ,c.course_name as 'CRS', c.course_no as 'NUMBER', d.depart_name as 'DEPART', c.course_credit as 'CREDIT', o.offer_year as 'YEAR', o.offer_term as 'TERM',c.prereq as 'Pre' " +
                                "from Course_info c " +
                                "inner join Depart_info d on c.Depart_ID = d.Depart_ID " +
                                "left join offer_info o on (o.Offer_ID = c.Offer_ID) " +
                                "where c.Offer_ID = '014FA' ";

            string searchQry2 = "select c.course_id as 'ID' ,c.course_name as 'CRS', c.course_no as 'NUMBER', d.depart_name as 'DEPART', c.course_credit as 'CREDIT', o.offer_year as 'YEAR', o.offer_term as 'TERM',c.prereq as 'Pre' " +
                                "from Course_info c " +
                                "inner join Depart_info d on c.Depart_ID = d.Depart_ID " +
                                "left join offer_info o on (o.Offer_ID = c.Offer_ID) " +
                                "where c.Offer_ID = '014FA' " +
                                "and c.course_no ='" + NumSearch + "'";

            string searchQry3 = "select c.course_id as 'ID' ,c.course_name as 'CRS', c.course_no as 'NUMBER', d.depart_name as 'DEPART', c.course_credit as 'CREDIT', o.offer_year as 'YEAR', o.offer_term as 'TERM',c.prereq as 'Pre' " +
                                "from Course_info c " +
                                "inner join Depart_info d on c.Depart_ID = d.Depart_ID " +
                                "left join offer_info o on (o.Offer_ID = c.Offer_ID) " +
                                "where c.Offer_ID = '014FA' " +
                                "and c.course_level ='" + lvlSearch + "'";

            string searchQry4 = "select c.course_id as 'ID' ,c.course_name as 'CRS', c.course_no as 'NUMBER', d.depart_name as 'DEPART', c.course_credit as 'CREDIT', o.offer_year as 'YEAR', o.offer_term as 'TERM',c.prereq as 'Pre' " +
                                "from Course_info c " +
                                "inner join Depart_info d on c.Depart_ID = d.Depart_ID " +
                                "left join offer_info o on (o.Offer_ID = c.Offer_ID) " +
                                "where c.Offer_ID = '014FA' " +
                                "and c.course_no ='" + NumSearch + "' " +
                                "and c.course_level ='" + lvlSearch + "'";

            string searchQry5 = "select c.course_id as 'ID' ,c.course_name as 'CRS', c.course_no as 'NUMBER', d.depart_name as 'DEPART', c.course_credit as 'CREDIT', o.offer_year as 'YEAR', o.offer_term as 'TERM',c.prereq as 'Pre' " +
                                "from Course_info c " +
                                "inner join Depart_info d on c.Depart_ID = d.Depart_ID " +
                                "left join offer_info o on (o.Offer_ID = c.Offer_ID) " +
                                "where c.Offer_ID = '014FA' " +
                                "and d.depart_id ='" + deptSearch + "'";

            string searchQry6 = "select c.course_id as 'ID' ,c.course_name as 'CRS', c.course_no as 'NUMBER', d.depart_name as 'DEPART', c.course_credit as 'CREDIT', o.offer_year as 'YEAR', o.offer_term as 'TERM',c.prereq as 'Pre' " +
                                "from Course_info c " +
                                "inner join Depart_info d on c.Depart_ID = d.Depart_ID " +
                                "left join offer_info o on (o.Offer_ID = c.Offer_ID) " +
                                "where c.Offer_ID = '014FA' " +
                                "and c.course_no ='" + NumSearch + "' " +
                                "and d.depart_id ='" + deptSearch + "'";

            string searchQry7 = "select c.course_id as 'ID' ,c.course_name as 'CRS', c.course_no as 'NUMBER', d.depart_name as 'DEPART', c.course_credit as 'CREDIT', o.offer_year as 'YEAR', o.offer_term as 'TERM',c.prereq as 'Pre' " +
                                "from Course_info c " +
                                "inner join Depart_info d on c.Depart_ID = d.Depart_ID " +
                                "left join offer_info o on (o.Offer_ID = c.Offer_ID) " +
                                "where c.Offer_ID = '014FA' " +
                                "and c.course_level ='" + lvlSearch + "' " +
                                "and d.depart_id ='" + deptSearch + "'";

            string searchQry8 = "select c.course_id as 'ID' ,c.course_name as 'CRS', c.course_no as 'NUMBER', d.depart_name as 'DEPART', c.course_credit as 'CREDIT', o.offer_year as 'YEAR', o.offer_term as 'TERM',c.prereq as 'Pre' " +
                                "from Course_info c " +
                                "inner join Depart_info d on c.Depart_ID = d.Depart_ID " +
                                "left join offer_info o on (o.Offer_ID = c.Offer_ID) " +
                                "where c.Offer_ID = '014FA' " +
                                "and c.course_no ='" + NumSearch + "' " +
                                "and c.course_level ='" + lvlSearch + "' " +
                                "and d.depart_id ='" + deptSearch + "'";
            #endregion
            #region Searching Parts
            if (depart_combo.SelectedItem.ToString() == "All Departments")
            {
                if (level_combo.SelectedItem.ToString() == "All Course Level")
                {
                    if (numberSearch.TextLength == 0)
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry1, objconn);
                        data_To_Grid(searchQuery, searchGrid);
                    }
                    else
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry2, objconn);
                        data_To_Grid(searchQuery, searchGrid);
                    }
                }
                else
                {
                    if (numberSearch.TextLength == 0)
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry3, objconn);
                        data_To_Grid(searchQuery, searchGrid);
                    }
                    else
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry4, objconn);
                        data_To_Grid(searchQuery, searchGrid);
                    }
                }
            }
            else
            {
                if (level_combo.SelectedItem.ToString() == "All Course Level")
                {
                    if (numberSearch.TextLength == 0)
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry5, objconn);
                        data_To_Grid(searchQuery, searchGrid);
                    }
                    else
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry6, objconn);
                        data_To_Grid(searchQuery, searchGrid);
                    }
                }
                else
                {
                    if (numberSearch.TextLength == 0)
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry7, objconn);
                        data_To_Grid(searchQuery, searchGrid);
                    }
                    else
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry8, objconn);
                        data_To_Grid(searchQuery, searchGrid);
                    }
                }
            }
            #endregion
            searchGrid.ClearSelection();
        }


        private void checkReq_button_Click(object sender, EventArgs e)
        {

            currentUserID = SID_Text.Text;
            if (searchGrid.RowCount > 0)
            {
                selectedID = searchGrid.SelectedRows[0].Cells["ID"].Value.ToString();
                prereqResult = searchGrid.SelectedRows[0].Cells["Pre"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Nothing is in data table");
            }

            #region Adding Course Restriction

            string preQuery1 = "SELECT DISTINCT p.course_id, p.precourse_id, r.student_no, c.course_name, c.course_no " +
                               "FROM prere_info p, registered_info r, course_info c " +
                               "WHERE p.course_id= '" + selectedID + "' " +
                               "AND r.student_no ='" + SID_Text.Text + "' " +
                               "AND p.precourse_id = c.course_id " +
                               "AND " +
                               "p.precourse_id not in " +
                               "(select pp.precourse_id " +
                               "FROM prere_info pp, registered_info r " +
                               "WHERE r.course_id = pp.precourse_id " +
                               "and r.grade_point > 1.67 )";

            string creditQuery = "select distinct count(r.offer_id)*3 as cCredit " +
                                 "from registered_info r " +
                                 "where r.Student_no = '" + currentUserID + "' ";

            string addQuery = "INSERT INTO registered_info(Student_no, course_id, offer_id, Grade_point) " +
                              "values('" + currentUserID + "','" + selectedID + "','014FA','0')";

            string dupQuery = "SELECT CASE WHEN EXISTS " +
                              "(SELECT course_id " +
                              "FROM registered_info " +
                              "where student_no = '" + currentUserID + "' " +
                              "AND course_id = '" + selectedID + "') " +
                              "THEN " +
                              "CAST(1 as BIT) ELSE " +
                              "CAST(0 as BIT) END";


            #endregion


            if (searchGrid.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("No course has been selected.", "Error");
            }
            else
            {
                
                objconn.Open();
                SqlDataAdapter preQ = new SqlDataAdapter(preQuery1, objconn);
                DataTable dt = new DataTable();
                preQ.Fill(dt);
                int index = dt.Rows.Count;
                string[] failname, failnumber, preQfailcourse;
                SqlCommand creditQ = new SqlCommand(creditQuery, objconn);
                creditResult = (int)creditQ.ExecuteScalar();

                if (prereqResult == "True")
                {

                    if (index != 0)
                    {
                        failname = new string[index];
                        failnumber = new string[index];
                        preQfailcourse = new string[index];

                        for (int i = 0; i < index; i++)
                        {
                            failname[i] = dt.Rows[i]["course_name"].ToString();
                            failnumber[i] = dt.Rows[i]["course_no"].ToString();
                        }

                        for (int i = 0; i < index; i++)
                        {
                            preQfailcourse[i] = failname[i] + failnumber[i];
                        }

                        string result = String.Join(" and ", preQfailcourse);
                        MessageBox.Show("You need to take " + result + " first.");
                    }

                    else
                    {
                       
                        MessageBox.Show("Eligible to enroll the selected course");
                        MessageBox.Show("You have " + creditResult + "credits. You can add maximum " + ((18 - creditResult) / 3) + "more courses.", "Information");
                        MessageBox.Show("Selected course has been added.");
                        SqlCommand addC = new SqlCommand(addQuery, objconn);
                        addC.ExecuteNonQuery();

                    }
                    objconn.Close();
                }

                else
                {
                    
                    
                    SqlDataAdapter dupQ = new SqlDataAdapter(dupQuery, objconn);
                    DataTable dupDt = new DataTable();
                    
                    
                    
                    dupQ.Fill(dupDt);

                    dupResult = dupDt.Rows[0][0].ToString();
                
                
                    

                    if (creditResult < 18)
                    {
                        if (dupResult == "True")
                        {
                            MessageBox.Show("You have duplicated course. #Course ID : " + selectedID + "", "Course Duplication Warning");
                            MessageBox.Show("Cancel Selected course.");
                        }

                        else
                        {
                            MessageBox.Show("You have " + creditResult + "credits. You can add maximum " + ((18 - creditResult) / 3) + "more courses.", "Information");
                            MessageBox.Show("Selected course has been added.");
                            SqlCommand addC = new SqlCommand(addQuery, objconn);
                            addC.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Maximum credit limit reached. You cannot register courses");
                    }



                    objconn.Close();
                }
            }
        }

        private void addedcourse_button_Click(object sender, EventArgs e)
        {
            currentUserID = SID_Text.Text;
            this.tabControl1.SelectedIndex = 2;

            #region result Quaries
            string addedQry = "SELECT r.Student_no AS ID, c.course_id AS CRSID, c.course_name AS Crs, c.course_no AS Number, o.offer_year AS Year, o.offer_term AS Term " +
                              "FROM registered_info r " + 
                              "inner join course_info c on (r.course_id = c.course_id) " +
                              "inner join offer_info o on (o.offer_id = r.offer_id) " +
                              "where r.offer_id = '014FA' " +
                              "and r.Student_no = '"+currentUserID+"' ";

            string addedQry2 = "SELECT r.Student_no AS ID, c.course_id AS CRSID, c.course_name AS Crs, c.course_no AS Number, o.offer_year AS Year, o.offer_term AS Term " +
                              "FROM registered_info r " +
                              "inner join course_info c on (r.course_id = c.course_id) " +
                              "inner join offer_info o on (o.offer_id = r.offer_id) " +
                              "where r.offer_id = '014SU' " +
                              "and r.Student_no = '" + currentUserID + "' ";
            #endregion

            objconn.Open();

            SqlDataAdapter addedQ = new SqlDataAdapter(addedQry,objconn);
            SqlDataAdapter addedQ2 = new SqlDataAdapter(addedQry2, objconn);
            DataTable addDt = new DataTable();
            DataTable addDt2 = new DataTable();
            addedQ.Fill(addDt);
            addedQ2.Fill(addDt2);
            finalGrid.DataSource = addDt;
            currentTermgrid.DataSource = addDt2;
            objconn.Close();

        }

        private void drop_btn_Click(object sender, EventArgs e)
        {
            objconn.Open();
            selectedID = finalGrid.SelectedRows[0].Cells["CRSID"].Value.ToString();
            int index = finalGrid.CurrentCell.RowIndex;
            string dropQry = "DELETE FROM registered_info " +
                             "where course_id ='"+selectedID+"' " +
                             "and offer_id = '014FA' ";
            SqlCommand dropQ = new SqlCommand(dropQry, objconn);
            dropQ.ExecuteNonQuery();
            finalGrid.Rows.RemoveAt(index);
            MessageBox.Show("Selected Course has been dropped succesfully.");
            objconn.Close();
            if (finalGrid.RowCount == 0)
            {
                MessageBox.Show("You have registered any courses!"); 
            }

        }

        

   
    }
}
