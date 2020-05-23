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
            var v1 = txt1.Text;
            var v1Like = "%" + v1+ "%";

            var v2 = radioButton1.Checked;
            using (XUELONGEntities context = new XUELONGEntities())
            {

                //context.V_STOCK_CURRENT_List.Where(s => s.cinvcode == v1).Load();
                if (v2)
                {
                    context.V_STOCK_CURRENT_List.Where(s => DbFunctions.Like(s.cinvcode, v1Like)).Take(999).Load();
                }
                else
                {
                    context.V_STOCK_CURRENT_List.Where(s => s.cinvcode == v1).Take(999).Load();


                }
                dataGridView1.DataSource = context.V_STOCK_CURRENT_List.Local.ToBindingList();
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }

            }
            lblMsg.Text = "[庫存管理->庫存查詢]模糊查詢料號 " + txt1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            dataGridView1.DataSource = null;
        }
    }
}
