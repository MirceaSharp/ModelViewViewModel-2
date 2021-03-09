using System;

namespace MVVM_voorbeeld_Oplossing
{
    class TV
    {
        private int _kanaal;
        private int _volume;
        private bool _teletekst;
        private bool _power;
        private string _merk;
        private string _type;
        private int _herz;
        private int _beeldgrootte;
        private string _afbeelding;


        public TV() : this("", "", 0, 0, "")
        {
        }


        public TV(string merk, String type, int herz, int beeldgrootte, string afbeelding)
        {
            Merk = merk;
            Type = type;
            Herz = herz;
            Beeldgrootte = beeldgrootte;
            Afbeelding = afbeelding;
            Power = false;
            Kanaal = 0;
            Volume = 0;
            Teletekst = false;
        }

        public int Kanaal
        {
            get { return _kanaal; }
            set
            {
                if (Power == true)
                {
                    _kanaal = value;
                }
            }
        }

        public int Volume
        {
            get { return _volume; }
            set
            {
                if (Power == true)
                {
                    _volume = value;
                }
            }
        }

        public bool Teletekst
        {
            get { return _teletekst; }
            set { _teletekst = value; }
        }

        public bool Power
        {
            get { return _power; }
            set { _power = value; }
        }

        public string Merk
        {
            get { return _merk; }
            set { _merk = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Herz
        {
            get { return _herz; }
            set { _herz = value; }
        }

        public int Beeldgrootte
        {
            get { return _beeldgrootte; }
            set { _beeldgrootte = value; }
        }

        public string Afbeelding
        {
            get { return _afbeelding; }
            set { _afbeelding = value; }
        }


        public override String ToString()
        {
            string tekst = "Merk: " + Merk + Environment.NewLine;
            tekst += "Type: " + Type + Environment.NewLine;
            tekst += "Herz: " + Herz + Environment.NewLine;
            tekst += "Beeldgrootte: " + Beeldgrootte + Environment.NewLine;
            return tekst;
        }

    }
}
