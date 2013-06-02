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
        private String state;

        private BindingSource playerBindingSource;

        public CompetitionForm()
        {
            Init();
            state = "NEW";
            SetContentFieldsEnabled(false);
        }

        public CompetitionForm(int tävling_id)
        {
            Init();
            EditMode(tävling_id);
        }

        private void EditMode(int tävling_id)
        {
            state = "EDIT";
            SetContentFieldsEnabled(true);
            this.tävling_id = tävling_id;
            this.Text = "Ändra tävling: " + tävling_id.ToString();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"Tävling\" WHERE \"Tävling_id\" = '" + tävling_id.ToString() + "';", MainWindow.dbConnection);
            NpgsqlDataReader ndr = command.ExecuteReader();
            ndr.Read();
            name_textBox.Text = (String) ndr["namn"];
            ndr.Close();

            DataTable player_table = new DataTable("Table");
            player_table.Columns.Add("Golf-ID", typeof(string));
            player_table.Columns.Add("Namn", typeof(string));
            player_table.Columns.Add("Handicap", typeof(string));
            command = new NpgsqlCommand("SELECT    \"Medlem\".\"Golf-ID\",    \"Medlem\".\"Förnamn\",    \"Medlem\".\"Efternamn\",    \"Medlem\".\"Handicap\" FROM    public.\"Tävling_Medlem\",    public.\"Medlem\" WHERE    \"Tävling_Medlem\".\"Golf-ID\" = \"Medlem\".\"Golf-ID\" AND   \"Tävling_Medlem\".\"Tävling_id\" = " + tävling_id.ToString() + ";", MainWindow.dbConnection);
            ndr = command.ExecuteReader();
            while (ndr.Read())
            {
                DataRow dr = player_table.NewRow();
                dr["Golf-ID"] = ndr["Golf-ID"];
                dr["Namn"] = ndr["Förnamn"] + " " + ndr["Efternamn"];
                dr["Handicap"] = ndr["Handicap"];
                player_table.Rows.Add(dr);
            }
            ndr.Close();

            SetPlayerTable(player_table);
        }

        private void SetPlayerTable(DataTable dt)
        {
            playerBindingSource = new BindingSource(dt, null);

            //Set the component data
            players_dataGridView.DataSource = playerBindingSource;

            //Set column header text
            players_dataGridView.Columns[0].HeaderText = "Golf-ID";
            players_dataGridView.Columns[1].HeaderText = "Namn";
            players_dataGridView.Columns[2].HeaderText = "Handicap";
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
            if (state.Equals("NEW"))
            {
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"Tävling\" (\"Namn\", \"SistaAnmälan\") VALUES (:name, :date); SELECT CURRVAL(pg_get_serial_sequence('\"Tävling\"','Tävling_id'));", MainWindow.dbConnection);
                command.Parameters.Add(new NpgsqlParameter(":name", DbType.String));
                command.Parameters.Add(new NpgsqlParameter(":date", DbType.DateTime));
                command.Parameters[0].Value = name_textBox.Text;
                command.Parameters[1].Value = date;
                NpgsqlDataReader result = command.ExecuteReader();
                result.Read();
                int curval = Convert.ToInt32(result["currval"]);
                result.Close();
                EditMode(curval);
                
            }
            else if (state.Equals("EDIT") && !name_textBox.Enabled)
            {
                SetContentFieldsEnabled(false);
            }
            else if (state.Equals("EDIT") && name_textBox.Enabled)
            {
                NpgsqlCommand command = new NpgsqlCommand("UPDATE \"Tävling\" SET (\"Namn\", \"SistaAnmälan\") = (:name, :date) WHERE \"Tävling_id\" = '" + tävling_id.ToString() + "';", MainWindow.dbConnection);
                command.Parameters.Add(new NpgsqlParameter(":name", DbType.String));
                command.Parameters.Add(new NpgsqlParameter(":date", DbType.DateTime));
                command.Parameters[0].Value = name_textBox.Text;
                command.Parameters[1].Value = date;
                NpgsqlDataReader result = command.ExecuteReader();
                EditMode(tävling_id);
                result.Close();
            }
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

            saveName_button.Text = !b ? "Spara" : "Ändra";
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

        private void remove_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Vill du verkligen ta bort tävlingen? " + tävling_id, "Ta bort tävling", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM \"Tävling\" WHERE \"Tävling_id\" = '" + tävling_id + "';", MainWindow.dbConnection);
                NpgsqlDataReader ndr = command.ExecuteReader();
                ndr.Close();
            }
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
