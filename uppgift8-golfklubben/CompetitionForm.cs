using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift8_golfklubben
{
    public partial class CompetitionForm : Form
    {
        private DateTime date = DateTime.Now;
        private int tävling_id;

        public CompetitionForm()
        {
            Init();
            SetContentFieldsEnabled(false);
        }

        public CompetitionForm(int tävling_id)
        {
            Init();
            SetContentFieldsEnabled(true);
            this.tävling_id = tävling_id;
        }

        private void Init()
        {
            InitializeComponent();
            time_comboBox.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveName_button_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"Tävling\" (\"Namn\", \"SistaAnmälan\") VALUES (:name, :date); SELECT CURRVAL(pg_get_serial_sequence('\"Tävling\"','Tävling_id'));", MainWindow.dbConnection);
            command.Parameters.Add(new NpgsqlParameter(":name", DbType.String));
            command.Parameters.Add(new NpgsqlParameter(":date", DbType.DateTime));
            command.Parameters[0].Value = name_textBox.Text;
            command.Parameters[1].Value = date;
            NpgsqlDataReader result = command.ExecuteReader();
            result.Read();
            tävling_id = (int) result["currval"];
            this.Text = "Ändra tävling: " + result["currval"];
            result.Close();
            SetContentFieldsEnabled(true);
        }

        private void SetContentFieldsEnabled(bool b) 
        {
            players_dataGridView.Enabled = b;
            players_addButton.Enabled = b;
            players_remButton.Enabled = b;
            times_dataGridView.Enabled = b;
            times_addButton.Enabled = b;
            times_remButton.Enabled = b;
            classes_dataGridView.Enabled = b;
            classes_addButton.Enabled = b;
            classes_remButton.Enabled = b;

            name_textBox.Enabled = !b;
            date_textBox.Enabled = !b;
            time_comboBox.Enabled = !b;
            monthCalendar.Enabled = !b;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateDateTime();
            monthCalendar.Visible = false;
        }

        private void UpdateDateTime()
        {
            date_textBox.Text = monthCalendar.SelectionStart.ToLongDateString();
            date = new DateTime(
                monthCalendar.SelectionStart.Year,
                monthCalendar.SelectionStart.Month,
                monthCalendar.SelectionStart.Day,
                int.Parse(time_comboBox.SelectedItem.ToString().Substring(0, 2)),
                int.Parse(time_comboBox.SelectedItem.ToString().Substring(3, 2)),
                0);
        }

        private void date_textBox_Enter(object sender, EventArgs e)
        {
            monthCalendar.Visible = true;
        }

        private void date_textBox_Leave(object sender, EventArgs e)
        {
            monthCalendar.Visible = false;
        }

        private void time_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDateTime();
        }
    }
}
