public void addrows(string qry, SuperGridControl dgv)
        {
            try
            {
                GridPanel panel = dgv.PrimaryGrid;
                panel.Rows.Clear();
                dgv.BeginUpdate();


                c.da = new SqlDataAdapter(qry, connection.con);
                c.dt = new DataTable();
                c.da.Fill(c.dt);
                foreach (DataRow row in c.dt.Rows)
                {
                    object[] ob1 = new object[]
                    {
                     row[0].ToString(), row[1].ToString(),row[2].ToString(),
                     row[3].ToString(), row[4].ToString(),row[5].ToString()
                    };
                    panel.Rows.Add(new GridRow(ob1));
                }
                dgv.EndUpdate();
            }
            catch (Exception ex)
            {
                com.showcustomermsg("Something Wrong!", "Error Message", "ShieldStop", ex.Message, "Red", "");
            }

        }
         private void labelX3_Click(object sender, EventArgs e)
        {
            this.superGridControl3.PrimaryGrid.Columns[3].HeaderText = "Address";
                        string q1 = @"select id,code,name,Address, phone1,phone2 from Customers";
                        addrows(q1, superGridControl3);
        }
