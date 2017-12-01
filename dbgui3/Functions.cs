using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace dbgui3
{
    public static class FunctionsList
    {
        
        private static string connstr = "server=mysql.cis.ksu.edu;user=jordanmartin;database=jordanmartin;port=3306;password=insecurepassword;Convert Zero Datetime=true;Allow User Variables=true";
        private static MySqlConnection conn = new MySqlConnection(connstr);
        public static void MySqlConnect()
        {
            conn = new MySqlConnection(connstr);
        }

        public static int totalParts()
        {
            conn.Open();
            string query = "select count(*) from part";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int max = 0;
            try
            {
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    max = sdr.GetInt32(0);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return max;
            
        }

        public static int totalEmployees()
        {
            conn.Open();
            string query = "select count(*) from employee";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int max = 0;
            try
            {
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    max = sdr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return max;
        }

        public static int totalJobs()
        {
            conn.Open();
            string query = "select count(*) from job where completed = 0";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int max = 0;
            try
            {
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    max = sdr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return max;
        }

        public static DataTable findJobID(int jid)
        {
            string query = "select job.id as 'Job ID', description as 'Process', j_date as 'Date', quantity as 'Quantity', CASE WHEN completed = 0 THEN 'False' ELSE 'True' END as Completed from job left outer join process on job.process_id = process.id where job.id like '%" + jid.ToString() + "%'";
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable datagrid = new DataTable();
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                { datagrid.Load(sdr); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return datagrid;
        }


        public static DataTable ProcessIDAutoComplete()
        {
            string query = "select process.id as pid, description, a.name as n, a.partid from process left outer join (select process_id, name, c.id as partid from part_produced b left outer join part c on b.part_id = c.id) a on process.id = a.process_id";
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable datagrid = new DataTable();
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                { datagrid = new DataTable(); datagrid.Load(sdr); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return datagrid;
        }

        public static DataTable SupplierIDAutoComplete()
        {
            string query = "select id as sid, name from supplier";
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable datagrid = new DataTable();
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                { datagrid = new DataTable(); datagrid.Load(sdr); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return datagrid;
        }

        public static DataTable findProcessIDint(string pid)
        {
            string query = "select job.id as 'Job ID', description as 'Process', j_date as 'Date', quantity as 'Quantity', CASE WHEN completed = 0 THEN 'False' ELSE 'True' END as Completed from job left outer join process on job.process_id = process.id where process.description like '%" + pid + "%'";
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable datagrid = new DataTable();
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                { datagrid.Load(sdr); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return datagrid;
        }

        public static DataTable findJobDate(string date1, string date2)
        {
            string query = "select job.id as 'Job ID', description as 'Process', j_date as 'Date', quantity as 'Quantity', CASE WHEN completed = 0 THEN 'False' ELSE 'True' END as Completed from job join process on job.process_id = process.id where j_date between '" + date1 + "' and '" + date2 + "'";
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable datagrid = new DataTable();
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                { datagrid = new DataTable(); datagrid.Load(sdr); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return datagrid;
        }

        /// <summary>
        /// Finds the jobs that are incomplete
        /// </summary>
        /// <returns>your mom</returns>
        public static DataTable findJobInc()
        {
            string query = "select * from job where completed = 0";
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable datagrid = new DataTable();
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                { datagrid = new DataTable(); datagrid.Load(sdr); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return datagrid;
        }

        public static DataTable findPartID(int pid)
        {
            string query = "select * from part where id =  " + pid.ToString();
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable datagrid = new DataTable();
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                { datagrid = new DataTable(); datagrid.Load(sdr); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return datagrid;
        }

        public static DataTable findPartName(string pname)
        {
            string query = "select * from part where name like '%" + pname + "%'";
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable datagrid = new DataTable();
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                { datagrid = new DataTable(); datagrid.Load(sdr); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return datagrid;
        }

        public static DataTable findCustomerPurchases(int cid)
        {
            string query = "select * from purchase where customer_id = " + cid.ToString();
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable datagrid = new DataTable();
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                { datagrid = new DataTable(); datagrid.Load(sdr); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return datagrid;
        }

        public static DataTable analysisdata()
        {
            string query = "select part_id, p_date, price_per, base_cost from purchase left outer join part on part_id = id";
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable datagrid = new DataTable();
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                { datagrid = new DataTable(); datagrid.Load(sdr); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return datagrid;

        }

        public static DataTable findEmployee(string name, string skill, int id)
        {
            
            string query = "select name, job_title, salary, address from employee e join person p on e.id = p.id where p.name like '%"
                + name + "%' and e.job_title like '%" + skill + "%'";
            if (id != -1)
            {
                query = query + " and e.id = " + id.ToString();
            }
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable datagrid = new DataTable();
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                { datagrid = new DataTable(); datagrid.Load(sdr); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return datagrid;
        }

        public static string insertUpdateJob(int jid, int pid, string date, int qty, bool complete)
        {
            int compl = 0;
            if (complete) { compl = 1; }
            else { compl = 0; }

            string query = "select exists(select 1 from job where id = " + jid.ToString() + ")";
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            bool exists = false;
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                {
                    sdr.Read();
                    exists = sdr.GetBoolean(0);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            if (exists)
            {
                conn.Open();
                string query2 = "update job set j_date = '" + date + "', completed = " + compl + " where id = " + jid;
                MySqlCommand command2 = new MySqlCommand(query2, conn);
                try
                {
                    command2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                    return "Update Failed";
                }
                conn.Close();
                return "Success";
            }
            else
            {
                string query2 = "select part_id, quantity from part_used where process_id = " + pid.ToString();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query2, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable datagrid = new DataTable();
                datagrid.Load(rdr);
                conn.Close();
                foreach (DataRow r in datagrid.Rows)
                {
                    int part = Convert.ToInt32(r[0]);
                    int quantity = Convert.ToInt32(r[1]);
                    conn.Open();
                    query2 = "update part set quantity = (quantity - " + (quantity * qty).ToString() + ") where id = " + part.ToString();
                    MySqlCommand command1 = new MySqlCommand(query2, conn);
                    try
                    {
                        command1.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show(ex.Message);
                        return "Update Failed";
                    }
                    conn.Close();
                }
                conn.Open();
                query2 = "insert into job(id, process_id, j_date, quantity, completed) values(" + jid.ToString() + ", " + pid.ToString() + ", '"
                    + date + "', " + qty.ToString() + ", " + compl + ")";
                MySqlCommand command2 = new MySqlCommand(query2, conn);
                try
                {
                    command2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    return "Insert Failed";
                }
                conn.Close();
                return "Success";
            }
        }

        public static string insertUpdatePart(int id, string name, int qty, double baseCost)
        {

            string query = "select exists(select 1 from part where id = " + id.ToString() + ")";
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            bool exists = false;
            try
            {
                using (MySqlDataReader sdr = command.ExecuteReader())
                {
                    sdr.Read();
                    exists = sdr.GetBoolean(0);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();

            if (exists)
            {
                string query2 = "update part set quantity = " + qty.ToString() + ", base_cost = " + baseCost.ToString() + " where id = " + id;
                conn.Open();
                MySqlCommand command2 = new MySqlCommand(query2, conn);
                try
                {
                    command2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    return "Update Failed";
                }
                conn.Close();
                return "Success";
            }
            else
            {
                string query2 = "insert into part (id, name, quantity, base_cost) values (" + id.ToString() + ", '" + name + "', "
                    + qty + ", " + baseCost + ")";
                conn.Open();
                MySqlCommand command2 = new MySqlCommand(query2, conn);
                try
                {
                    command2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                    return "Update Failed";
                }
                conn.Close();
                return "Successful Insert";
            }
        }

        public static int newJobID()
        {
            conn.Open();
            string query = "select max(id) from job";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int max = 0;
            try
            {
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    max = sdr.GetInt32(0) + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return max;
        }

        public static int newPartID()
        {
            conn.Open();
            string query = "select max(id) from part";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int max = 0;
            try
            {
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    max = sdr.GetInt32(0) + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return max;
        }

        public static int newOrderID()
        {
            conn.Open();
            string query = "select max(id) from purchase_order";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int max = 0;
            try
            {
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    max = sdr.GetInt32(0) + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return max;
        }

        public static int newSaleID()
        {
            conn.Open();
            string query = "select max(id) from purchase";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int max = 0;
            try
            {
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    max = sdr.GetInt32(0) + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return max;
        }

        public static int newPersonID()
        {
            conn.Open();
            string query = "select max(id) from person";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int max = 0;
            try
            {
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    max = sdr.GetInt32(0) + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return max;
        }

        public static string insertOrder(int oid, int pid, int qty, int cid, double costPer, int sid)
        {
            string query = "update part set quantity = (quantity + " + qty.ToString() + ") where id = " + pid.ToString();
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Update Failed";
            }

            query = "insert into order_part(order_id, part_id, cost_per, quantity) values(" + oid.ToString() + ", " + pid.ToString() + ", "
                + costPer + ", " + qty + ")";
            conn.Open();
            MySqlCommand command2 = new MySqlCommand(query, conn);
            try
            {
                command2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Insert Failed";
            }
            conn.Close();

            query = "insert into order_part(id, supplier_id, o_date) values(" + oid.ToString() + ", " + sid.ToString() + ", '"
                + (DateTime.Now).ToString("MM/DD/YYYY") + "')";
            conn.Open();
            MySqlCommand command3 = new MySqlCommand(query, conn);
            try
            {
                command3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Insert Failed";
            }
            conn.Close();
            return "Success";


        }

        public static int insertPerson(string name, string address)
        {
            int pid = newPersonID();
            string query = "insert into person(id, name, address) values(" + pid.ToString() + ", '" + name + "', '" + address + "')";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return -1;
            }
            conn.Close();
            return pid;
        }

        public static string insertEmployee(string jtitle, string salary, string name, string address)
        {
            int pid = insertPerson(name, address);
            if (pid == -1)
            {
                return "Failed";
            }
            string query = "insert into employee (id, job_title, salary) values (" + pid.ToString() + ", '" + jtitle + "', " + salary + ")";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Insert Failed";
            }
            conn.Close();
            return "Success";
        }

        public static string partSold(int pid, int qty, int cid, int rid, double costPer, DateTime date)
        {
            string query = "select quantity from part where id = " + pid.ToString();
            int pqty = 0;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    pqty = sdr.GetInt32("quantity");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (pqty >= qty)
            {
                query = "update part set (quantity = " + (pqty - qty).ToString() + ") where id = " + pid.ToString();
                MySqlCommand command3 = new MySqlCommand(query, conn);
                try
                {
                    command3.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    return "Update Failed";
                }
            }
            else
            {
                conn.Close();
                return "WE DON'T HAVE THAT MANY PARTS";
            }

            query = "insert into purchase(customer_id, part_id, receipt_id, price_per, quantity, p_date) values(" + cid.ToString() + ", " + pid.ToString() + ", "
                + rid.ToString() + ", " + costPer.ToString() + ", " + qty + ", " + date.ToString("MM/DD/YYYY") + ")";
            conn.Open();
            MySqlCommand command2 = new MySqlCommand(query, conn);
            try
            {
                command2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Update Failed";
            }
            conn.Close();
            return "Success";
        }
    }
}

