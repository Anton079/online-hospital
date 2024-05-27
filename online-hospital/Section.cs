using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hospital
{
    public class Section
    {
        private int _idSection;
        private string _sectionName;
        private int _sectionFreeSeats;

        public Section(string proprietati)
        {
            String[] token = proprietati.Split(",");

            _idSection = int.Parse(token[0]);
            _sectionName = token[1];
            _sectionFreeSeats = int.Parse(token[2]);
        }

        public Section(int id, string sectionName,int sectionFreeSeats)
        {
            _idSection = id;
            _sectionName = sectionName;
            _sectionFreeSeats= sectionFreeSeats;
        }

        public int Id
        {
            get { return _idSection; }
            set { _idSection = value; }
        }

        public string SectionName
        {
            get { return _sectionName; }
            set { _sectionName = value; }
        }

        public int SectionFreeSeats
        {
            get { return _sectionFreeSeats; }
            set { _sectionFreeSeats = value; }
        }

        public string SectionInfo()
        {
            string text = " ";
            text += "Id sectie spital " + _idSection + "\n";
            text += "Nume sectie spital" + _sectionName + "\n";
            text += "Locuri libere " + _sectionFreeSeats + "\n";
            return text;
        }

        public string ToSave()
        {
            return this._idSection + "," + this._sectionName + "," + this._sectionFreeSeats;
        }
    }
}
