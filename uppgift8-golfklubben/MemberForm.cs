using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift8_golfklubben
{
    public partial class MemberForm : Form
    {
        private Member m;

        //Form state, can be ACTION, EDIT, NEW, VIEW
        private String state = "ACTION";

        public MemberForm(ref Member m)
        {
            this.m = m;
            InitializeComponent();

            if (m.IsEmpty)
            {
                state = "NEW";
            }

            if (state.Equals("NEW"))
            {
                this.Text = "Ny Medlem";
                action_button.Text = "Skapa";
            }
            Init();
        }

        private void Init()
        {
            //Get all Status levels
            String sql = "SELECT \"Namn\" FROM public.\"Status\" ORDER BY \"Status_id\" ASC;";
            NpgsqlCommand Command = new NpgsqlCommand(sql, MainWindow.dbConnection);
            NpgsqlDataReader result = Command.ExecuteReader();
            while (result.Read())
            {
                membership_comboBox.Items.Add(result.GetString(result.GetOrdinal("Namn")));
            }
            membership_comboBox.SelectedIndex = 0;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            if (state.Equals("VIEW"))
            {
                SetAllInputs(false);
            }

            //TODO Should have some form checking before this, and some Injection Prevention
            m.GolfId = golfId_1_textBox.Text + "-" + golfId_2_textBox.Text;
            m.FirstName = firstName_textBox.Text;
            m.LastName = lastName_textBox.Text;
            m.Membership = membership_comboBox.Text;
            m.Adress = adress_textBox.Text;
            m.Zipcode = zipcode_textBox.Text;
            m.City = city_textBox.Text;
            m.Phone = phone_textBox.Text;
            m.Email = email_textBox.Text;
            m.Handicap = handicap_textBox.Text;
            m.Paid = paid_checkBox.Checked ? "1" : "0";

            this.Close();
        }

        /**
         * Sets all input field and boxes to enabled state if true 
         */
        private void SetAllInputs(Boolean enabled)
        {
            golfId_1_textBox.Enabled = enabled;
            firstName_textBox.Enabled = enabled;
            lastName_textBox.Enabled = enabled;
            adress_textBox.Enabled = enabled;
            zipcode_textBox.Enabled = enabled;
            city_textBox.Enabled = enabled;
            phone_textBox.Enabled = enabled;
            email_textBox.Enabled = enabled;
            membership_comboBox.Enabled = enabled;
            handicap_textBox.Enabled = enabled;
            paid_checkBox.Enabled = enabled;
        }

        private String GetGolfIDSerial(String date)
        {
            Match match = Regex.Match(date, "^[0-9]{2}[0-9]{2}[0-9]{2}$");
            if (match.Success)
            {
                String sql = "SELECT \"Golf-ID\" FROM public.\"Medlem\" WHERE \"Golf-ID\" ~ '^" + date + "+';";
                NpgsqlCommand Command = new NpgsqlCommand(sql, MainWindow.dbConnection);
                NpgsqlDataReader result = Command.ExecuteReader();
                int value = 0;
                while (result.Read())
                {
                    String s = result.GetString(result.GetOrdinal("Golf-ID"));
                    int foo;
                    foo = int.Parse(s.Substring(7, 3));
                    if (foo > value)
                    {
                        value = foo;
                    }
                }
                value++;
                return value.ToString().PadLeft(3, '0');
            }
            else return "";
        }

        private void golfId_1_textBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (state == "NEW")
            {
                golfId_2_textBox.Text = GetGolfIDSerial(golfId_1_textBox.Text); 
            }
        }
    }
}
