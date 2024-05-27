using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hospital
{
    public class HospitalInformation
    {
        private int _idHospitalInfo;
        private string _programPublic;
        private int _hospitalPhone;
        private string _hospitalEmail;

        public HospitalInformation(string proprietati)
        {
            String[] token = proprietati.Split(',');

            _idHospitalInfo = int.Parse(token[0]);
            _programPublic = token[1];
            _hospitalPhone = int.Parse(token[2]);
            _hospitalEmail = token[3];
        }

        public HospitalInformation(int idHospitalInfo, string programPublic, int hospitalPhone,string hospitalEmail)
        {
            _idHospitalInfo = idHospitalInfo;
            _programPublic = programPublic;
            _hospitalPhone = hospitalPhone;
            _hospitalEmail=hospitalEmail;
        }

        public int IdHospitalInfo
        {
            get { return _idHospitalInfo; }
            set { _idHospitalInfo = value; }
        }

        public string ProgramPublic
        {
            get { return _programPublic; }
            set { _programPublic = value; }
        }

        public int HospitalPhone
        {
            get { return _hospitalPhone; }
            set { _hospitalPhone = value; }
        }

        public string HospitalEmail
        {
            get { return _hospitalEmail; }
            set { _hospitalEmail = value; }
        }

        public string HospitalInfo()
        {
            string text = " ";
            text += "Id : " + _idHospitalInfo + "\n";
            text += "Program public : " + _programPublic + "\n";
            text += "Număr de telefon spital : " + _hospitalPhone + "\n";
            text += "Email spital :" + _hospitalEmail + "\n";
            return text;
        }

        public string ToSave()
        {
            return this._idHospitalInfo + "," + this._programPublic + "," + this._hospitalPhone + "," + this._hospitalEmail;
        }
    }
}
