using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _560DB
{
    class Functions
    {
        private MySqlConnection conn;
        private string connstr = "server=mysql.cis.ksu.edu;user=jordanmartin;database=jordanmartin;port=3306;password=insecurepassword";

        public void MySqlConnect()
        {
            conn = new MySqlConnection(connstr);
        }

        public DataTable findJobID(int jid)
        {
            string query = "select * from job where id = " + jid.ToString();
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            DataTable datagrid = new DataTable();
            try {
                using (MySqlDataReader sdr = command.ExecuteReader())
                { datagrid = new DataTable(); datagrid.Load(sdr); }
            }
            catch (Exception ex) {MessageBox.Show(ex.Message);}
            conn.Close();
            return datagrid;
        }

        public DataTable findProcessIDint (int pid)
        {
            string query = "select * from job join process on job.process_id = process.id where job.process_id = " + pid.ToString();
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

        public DataTable findJobDate(string date)
        {
            string query = "select * from job where j_date = " + date;
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
        public DataTable findJobInc()
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

        public DataTable findPartID(int pid)
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

        public DataTable findPartName(string pname)
        {
            string query = "select * from part where name like %" + pname + "%";
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

        public DataTable findCustomerPurchases(int cid)
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

        public DataTable findEmployee(string name, string skill, int id)
        {
            string query = "select * from employee e join person p on e.id = p.id join employee_task et on e.id = et.employee_id join task t on et.task_id = t.id where p.name like %"
                + name + "% and t.description like %" + skill + "% and e.id = " + id.ToString();
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

        public string insertUpdateJob(int jid, int pid, string date, int qty, bool complete)
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
                    exists = sdr.GetBoolean();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (exists)
            {
                string query2 = "update job set date = " + date + ", completed = " + compl + " where id = " + jid;
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
                conn.Closer();
                return "Success";
            }
            else
            {
                string query2 = "select part_id, quantity from parused where process_id = " + pid.ToString();
                MySqlCommand cmd = new MySqlCommand(query2, conn);
                MySqlDataReader rdr = cmd.ExectuteReader();
                while (rdr.Read())
                {
                    int part = rdr.GetInt32("part_id");
                    int quantity = rdr.GetInt32("quantity");
                    query2 = "update part set quantity = quantity - " + (quantity * qty).ToString() + "where id = " + part.ToString();
                    MySqlCommand command1 = new MySqlCommand(query2, conn);
                    try
                    {
                        command1.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return "Update Failed";
                    }
                }
                query2 = "insert into job(id, process_id, j_date, quantity, completed) values(" + jid.ToString() + ", " + pid.ToString() + ", "
                    + date + ", " + qty.ToString() + ", " + compl + ")";
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

        public string insertUpdatePart(int id, string name, int qty, double baseCost)
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
                    exists = sdr.GetBoolean();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

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
                string query2 = "insert into part(id, name, quantity, base_cost) values(" + id.ToString() + ", " + name + ", "
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
                    return "Update Failed";
                }
                conn.Close();
                return "Success";
            }
        }

        public int newJobID()
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
                    max = sdr.GetInt32() + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return max;
        }

        public int newPartID()
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
                    max = sdr.GetInt32() + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return max;
        }

        public int newOrderID()
        {
            conn.Open();
            string query = "select max(id) from order";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int max = 0;
            try
            {
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    max = sdr.GetInt32() + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return max;
        }

        public int newOrderID()
        {
            conn.Open();
            string query = "select max(id) from order";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int max = 0;
            try
            {
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    max = sdr.GetInt32() + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return max;
        }

        public int newPersonID()
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
                    max = sdr.GetInt32() + 1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            conn.Close();
            return max;
        }

        public string insertOrder(int oid, int pid, int qty, int cid, double costPer)
        {
            string query = "update part set quantity = quantity + " + qty.ToString() + " where where id = " + pid.ToString();
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

            query = "insert into order(id, part_id, quantity, company_id, base_cost) values(" + oid.ToString() + ", " + pid.ToString() + ", "
                + qty + ", " + cid + ", " + costPer + ")";
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
            return "Success";
        }

        public string partSold(int pid, int qty, int cid, int rid, double costPer, DateTime date)
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
                    pqty = sdr.GetInt32();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (pqty >= qty)
            {
                query = "update part set quantity = " + (pqty - qty).ToString() + " where id = " + id;
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

        public string insertPerson(int pid, string name, string address)
        {
            string query = "insert into person(id, name, address) values(" + pid.ToString() + ", " + name + ", " + address + ")";
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

        public string insertCustomer(int pid, string email, string password)
        {
            string query = "insert into customer(id, email, password) values(" + pid.ToString() + ", " + email + ", " + password + ")";
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

        public string insertEmployee(int pid, string jtitle, string salary)
        {
            string query = "insert into employee(id, job_title, salary) values(" + pid.ToString() + ", " + jtitle + ", " + salary + ")";
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
    }
}
