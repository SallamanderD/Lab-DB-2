using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Benefits". При необходимости она может быть перемещена или удалена.
            this.benefitsTableAdapter.Fill(this.hostelDataSet.Benefits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.hostelDataSet.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.hostelDataSet.Students);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            roomsTableAdapter.Update(hostelDataSet);
            benefitsTableAdapter.Update(hostelDataSet);
            studentsTableAdapter.Update(hostelDataSet);
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = roomsBindingSource;
            dataGridView1.DataSource = roomsBindingSource;
            label1.Text = "Rooms";
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = studentsBindingSource;
            dataGridView1.DataSource = studentsBindingSource;
            label1.Text = "Students";
        }

        private void benefitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = benefitsBindingSource;
            dataGridView1.DataSource = benefitsBindingSource;
            label1.Text = "Benefits";
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new RSForm();
            rs.ShowDialog();
            benefitsTableAdapter.Fill(hostelDataSet.Benefits);
            studentsTableAdapter.Fill(hostelDataSet.Students);
            roomsTableAdapter.Fill(hostelDataSet.Rooms);
        }
    }
}
