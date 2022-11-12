using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace склад
{
    public partial class Form1 : Form
    {    
        private readonly BindingSource BSourse;
        public Form1()
        {
            InitializeComponent();
            BSourse = new BindingSource();
            dataGridView1.DataSource = ReadDb();
            repit();
        }
       
        private void CreateDb(addform infoform)
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHellper.Options()))
            {
                infoform.sclad.Id = Guid.NewGuid();
                db.ScladDB.Add(infoform.sclad);
                db.SaveChanges();
            }
        }
        private static List<sclad> ReadDb()
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHellper.Options()))
            {
                return db.ScladDB.ToList();
            }
        }
        private static void UpDateDb(sclad scld)
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHellper.Options()))
            {
                var Scld = db.ScladDB.FirstOrDefault(u => u.Id == scld.Id);
                if (Scld != null)
                {
                    Scld.name = scld.name;
                    Scld.raz = scld.raz;
                    Scld.mater = scld.mater;
                    Scld.kol = scld.kol;
                    Scld.min = scld.min;
                    Scld.price = scld.price;
                    Scld.fulprice = scld.fulprice;
                    db.SaveChanges();
                }
            }
        }
         private static void RemoveDb(sclad scld)
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHellper.Options()))
            {
                var Scld = db.ScladDB.FirstOrDefault(u => u.Id == scld.Id);
                if (scld != null)
                {
                    db.ScladDB.Remove(Scld);
                    db.SaveChanges();
                }
            }
        }
        public void repit()
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHellper.Options())) {
                toolStripStatusLabel1.Text = "Колличество товаров на складе: " + Convert.ToString(db.ScladDB.ToList().Count());
                toolStripStatusLabel3.Text = "Общая цена товаров(cНДС): " + Convert.ToString(db.ScladDB.ToList().Sum(x => x.fulprice + (x.fulprice * 0.2)));
                toolStripStatusLabel2.Text = "Общая цена товаров(безНДС): " + Convert.ToString(db.ScladDB.ToList().Sum(x => x.fulprice));
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var infoForm = new addform();
            infoForm.Text = "Добавление товара";
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {                
                BSourse.ResetBindings(false);
                CreateDb(infoForm);
                dataGridView1.DataSource = ReadDb();
                repit();
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var id = (sclad)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new addform(id);          
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                id.name = infoForm.sclad.name;
                id.mater = infoForm.sclad.mater;
                id.kol = infoForm.sclad.kol;
                id.raz = infoForm.sclad.raz;
                id.min = infoForm.sclad.min;
                id.price = infoForm.sclad.price;              
                id.fulprice = infoForm.sclad.fulprice;
                BSourse.ResetBindings(false);
                UpDateDb(id);  
                dataGridView1.DataSource = ReadDb();
                repit();
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = toolStripButton3.Enabled = dataGridView1.SelectedRows.Count > 0;
            удалитьToolStripMenuItem.Enabled = изменитьToolStripMenuItem.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DepterColumn")
            {
                var id = (sclad)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                e.Value = id.price + (id.price * 0.2);
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "noNDS")
            {
                var id = (sclad)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                e.Value = id.fulprice + (id.fulprice * 0.2);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var id = (sclad)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;      
            BSourse.ResetBindings(false);
            RemoveDb(id);
            dataGridView1.DataSource = ReadDb();
            repit();
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1_Click(sender, e);
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton3_Click(sender, e);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton2_Click(sender, e);
        }
        private void forprogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Склад гвоздей", "Бажин Кирилл Адреевич", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
     

