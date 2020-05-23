using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;
            //dataGridView1.Width = control.Width - 8;
           
            //dataGridView1.Size = new Size(control.Size.Width - 38, dataGridView1.Height);
        }
        public Form1()
        {
            InitializeComponent();
        }
        static void show(String info)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            System.Diagnostics.Debug.WriteLine(info);
            //Console.WriteLine(info);

        }
        static void show2(String info)
        {
            info += " ";
            //Console.OutputEncoding = Encoding.UTF8;
            System.Diagnostics.Debug.Write(info);
            //Console.Write(info);

        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "好久不見";

            var maxRec = 20;
            using (XUELONGEntities context = new XUELONGEntities())
            {
                var obj = context.V_STOCK_CURRENT_List.Where(s => s.cinvcode == "AB");
                obj.Load();
                //dataGridView1.DataSource = obj;
                //dataGridView1.Dock = DockStyle.Fill;
                //DataAdapter = new
                //https://stackoverflow.com/questions/42114690/what-is-the-correct-way-to-use-entity-framework-as-datasource-for-datagridview
                //t will work but the DbContext cannot track changes that way, you should use 
                
                context.V_STOCK_CURRENT_List.Where(s => s.cinvcode == "AB").Load(); 
                dataGridView1.DataSource = context.V_STOCK_CURRENT_List.Local.ToBindingList();
                dataGridView1.AutoResizeColumns();
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;

                //dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;

                //dataGridView1.RowTemplate.Height = 50;
                foreach(DataGridViewRow row in dataGridView1.Rows )
                {
                    row.Height = 35;
                }



                var cnt = 0;
                //foreach (var x in context.V_BASE_CARGOSPACE_L.Where(s => s.cpositioncode == "XL-001"))
                foreach (var x in context.V_STOCK_CURRENT_List.Where(s => s.cinvcode == "AB"))
                {
                    cnt += 1;
                    if (cnt > maxRec)
                    {
                        break;
                    }
                    foreach (var col in x.GetType().GetProperties())
                    {
                        //show(col.ToString());

                        //show(col.Name.ToString());

                        var v2 = context.Entry(x).Property(col.Name.ToString()).CurrentValue;
                        if (v2 != null)
                        {

                            show2(v2.ToString());
                        }





                    }

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
