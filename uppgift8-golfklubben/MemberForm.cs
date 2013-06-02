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

        private DateTime dt = DateTime.Now;


        public MemberForm(ref Member m, String state)
        {
            this.m = m;
            InitializeComponent();
            Init();
            SetState(state);
        }

        private void SetState(String state)
        {
            this.state = state;
            SetState();
        }

        private void SetState()
        {
            if (state.Equals("NEW"))
            {
                this.Text = "Ny Medlem";
                action_button.Text = "Skapa";
            }

            if (state.Equals("VIEW"))
            {
                FillMemberData();
                this.Text = "Visa medlem: " + m.GolfId;
                action_button.Text = "Ändra";
                SetFieldsEnabled(false);
            }

            if (state.Equals("EDIT"))
            {
                FillMemberData();
                this.Text = "Ändra medlem: " + m.GolfId;
                action_button.Text = "Spara";
                SetFieldsEnabled(true);
            }
        }

        private void SetFieldsEnabled(bool e)
        {
            golfId_1_textBox.Enabled = false;
            golfId_2_textBox.Enabled = false;
            firstName_textBox.Enabled = e;
            lastName_textBox.Enabled = e;
            adress_textBox.Enabled = e;
            zipcode_textBox.Enabled = e;
            city_textBox.Enabled = e;
            phone_textBox.Enabled = e;
            email_textBox.Enabled = e;
            membership_comboBox.Enabled = e;
            handicap_textBox.Enabled = e;
            paid_checkBox.Enabled = e;
        }

        private void FillMemberData() 
        {
            golfId_1_textBox.Text = m.GolfId.Substring(0, 6);
            golfId_2_textBox.Text = m.GolfId.Substring(7, 3);
            firstName_textBox.Text = m.FirstName;
            lastName_textBox.Text = m.LastName;
            adress_textBox.Text = m.Adress;
            zipcode_textBox.Text = m.Zipcode;
            city_textBox.Text = m.City;
            phone_textBox.Text = m.Phone;
            email_textBox.Text = m.Email;
            membership_comboBox.SelectedIndex = int.Parse(m.Membership)-1;
            paid_checkBox.Checked = int.Parse(m.Paid) >= int.Parse(dt.Year.ToString());
            handicap_textBox.Text = m.Handicap;
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
                SetState("EDIT");
            }
            else if (state.Equals("NEW") || state.Equals("EDIT"))
            {
                m.GolfId = golfId_1_textBox.Text + "-" + golfId_2_textBox.Text;
                m.FirstName = firstName_textBox.Text;
                m.LastName = lastName_textBox.Text;
                m.Membership = (membership_comboBox.SelectedIndex + 1).ToString();
                m.Adress = adress_textBox.Text;
                m.Zipcode = zipcode_textBox.Text;
                m.City = city_textBox.Text;
                m.Phone = phone_textBox.Text;
                m.Email = email_textBox.Text;
                m.Handicap = handicap_textBox.Text;
                m.Paid = paid_checkBox.Checked ? dt.Year.ToString() : "0";
                this.Close();
            }
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
