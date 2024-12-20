using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace REMS
{
    class OccupantInfo
    {
        public string name, phoneNumber, email, houseType;
        public int houseId;

        OccupantDB odb = new OccupantDB();

        public OccupantInfo() { }

        public OccupantInfo (string name, string pNumber, string email, int houseId, string houseType)
        {
            this.name = name;
            this.phoneNumber = pNumber;
            this.email = email;
            this.houseId = houseId;
            this.houseType = houseType;
        }

        public bool checkEmail(string email)
        {

            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                //Normalize the domain
                email = Regex.Replace (email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                //Examine the domain part of the email
                string DomainMapper(Match match)
                {
                    //IdnMapping class to convert Unicode domain names
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                /*
                 * 
                 ^ - Begin the match at the start of the string
                [^@\s]+	- Match one or more occurences of any character other than the @ character of whiteSpace
                @ - Match the @ character
                \.	- Match a single period character
                $ - End match at the end of the string
                 
                 */
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public bool checkPhone (string phone)
        {
            long val;
            bool check = false;
            try
            {
                if (string.IsNullOrWhiteSpace(phone))
                    return false;
                if (long.TryParse(phone, out val))
                {
                    if (phone.StartsWith("0"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The phone number you entered is not in a valid format");
            }

            return check;
        }

        public void setForm(int oid)
        {
            DataTable dtOcc = odb.getOccupantInfo(oid);
            name = (string)dtOcc.Rows[0][1];
            phoneNumber = (string)dtOcc.Rows[0][2];
            email = (string)dtOcc.Rows[0][3];
            houseId  = (int)dtOcc.Rows[0][4];
            houseType = (string)dtOcc.Rows[0][5];
        }
    }
}
