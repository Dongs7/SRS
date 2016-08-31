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
    public partial class searchForm : Form
    {
        SqlConnection objconn = new SqlConnection("Data Source=cypress.csil.sfu.ca;" + "Initial Catalog=dca29354;" + "Trusted_Connection=Yes;" + "User ID=s_dca29;" + "Password=naRHYgAQ2YnJ7gM3");
        SqlDataReader reader;
        string NumSearch, lvlSearch, deptSearch;

        public searchForm()
        {
            InitializeComponent();
            fillCombo();
            term_combo2.SelectedIndex = 0;
            depart_combo2.SelectedIndex = 0;
            level_combo2.SelectedIndex = 0;
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
        private void fillCombo()
        {
            string fillQuery = " SELECT DISTINCT (depart_ID +' '+ depart_Name) as department FROM depart_info;";
            SqlCommand fillConn = new SqlCommand(fillQuery, objconn);
            objconn.Open();
            reader = fillConn.ExecuteReader();

            while (reader.Read())
            {
                string courses = reader["department"].ToString();
                depart_combo2.Items.Add(courses);
            }
            reader.Close();
            objconn.Close();
        }
        private void search2_btn_Click(object sender, EventArgs e)
        {
            
            NumSearch = numberSearch2.Text;
            lvlSearch = Convert.ToString(level_combo2.SelectedItem).Substring(0, 4);
            deptSearch = Convert.ToString(depart_combo2.SelectedItem).Substring(0, 2);

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
            if (depart_combo2.SelectedItem.ToString() == "All Departments")
            {
                if (level_combo2.SelectedItem.ToString() == "All Course Level")
                {
                    if (numberSearch2.TextLength == 0)
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry1, objconn);
                        data_To_Grid(searchQuery, searchOnlyGrid);
                    }
                    else
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry2, objconn);
                        data_To_Grid(searchQuery, searchOnlyGrid);
                    }
                }
                else
                {
                    if (numberSearch2.TextLength == 0)
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry3, objconn);
                        data_To_Grid(searchQuery, searchOnlyGrid);
                    }
                    else
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry4, objconn);
                        data_To_Grid(searchQuery, searchOnlyGrid);
                    }
                }
            }
            else
            {
                if (level_combo2.SelectedItem.ToString() == "All Course Level")
                {
                    if (numberSearch2.TextLength == 0)
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry5, objconn);
                        data_To_Grid(searchQuery, searchOnlyGrid);
                    }
                    else
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry6, objconn);
                        data_To_Grid(searchQuery, searchOnlyGrid);
                    }
                }
                else
                {
                    if (numberSearch2.TextLength == 0)
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry7, objconn);
                        data_To_Grid(searchQuery, searchOnlyGrid);
                    }
                    else
                    {
                        SqlDataAdapter searchQuery = new SqlDataAdapter(searchQry8, objconn);
                        data_To_Grid(searchQuery, searchOnlyGrid);
                    }
                }
            }
            #endregion
            searchOnlyGrid.ClearSelection();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            term_combo2.SelectedIndex = 0;
            depart_combo2.SelectedIndex = 0;
            level_combo2.SelectedIndex = 0;
            dataGrid_Empty(searchOnlyGrid);
           
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
