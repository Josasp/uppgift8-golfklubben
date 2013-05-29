using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift8_golfklubben
{
    public class Member
    {
        private String golfId = "";
        private String firstName = "";
        private String lastName = "";
        private String adress = "";
        private String zipcode = "";
        private String city = "";
        private String phone = "";
        private String email = "";
        private String membership = "";
        private String handicap = "";
        private String paid = "";
        private String gender = "";

        public Boolean IsEmpty
        {
            get
            {
                //Check if everything is empty
                if (
                    golfId.Length < 1 &&
                    firstName.Length < 1 &&
                    lastName.Length < 1 &&
                    adress.Length < 1 &&
                    zipcode.Length < 1 &&
                    city.Length < 1 &&
                    phone.Length < 1 &&
                    email.Length < 1 &&
                    membership.Length < 1 &&
                    handicap.Length < 1 &&
                    paid.Length < 1 &&
                    gender.Length < 1)
                {
                    return true;
                }
                else
                { 
                    return false;
                }
                
            }
            set
            { 
                
            }
        }

        public String GolfId
        {
            get 
            {
                return golfId;
            }
            set
            {
                golfId = value;
            }
        }

        public String FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public String LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public String Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }

        public String Zipcode
        {
            get
            {
                return zipcode;
            }
            set
            {
                zipcode = value;
            }
        }

        public String City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public String Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public String Membership
        {
            get
            {
                return membership;
            }
            set
            {
                membership = value;
            }
        }

        public String Handicap
        {
            get
            {
                return handicap;
            }
            set
            {
                handicap = value;
            }
        }

        public String Paid
        {
            get
            {
                return paid;
            }
            set
            {
                paid = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
    }
}
