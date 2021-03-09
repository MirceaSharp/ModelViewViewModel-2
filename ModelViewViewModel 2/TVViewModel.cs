namespace MVVM_voorbeeld_Oplossing
{
    class TVViewModel : ViewModelBase
    {
        private bool _sony;
        private bool _samsung;
        private bool _Power;
        private string _txtKanaal;
        private string _txtVolume;
        private string _lblEigenschappen;


        private string _afbeelding;

        TV mijnSony = new TV("Sony", "kdl46hx750bae2", 800, 40, "sony_kdl46hx750bae2.jpg");
        TV mijnSamung = new TV("Samsung", "ue46es7000", 800, 46, "samsung_ue46es7000.jpg");

        private void VulViewModelOp()
        {
            if (_sony)
            {
                TxtKanaal = mijnSony.Kanaal.ToString();
                TxtVolume = mijnSony.Volume.ToString();
                Power = mijnSony.Power;
                LblEigenschappen = mijnSony.ToString();
                Afbeelding = @"images\" + mijnSony.Afbeelding;
            }
            else
            {
                TxtKanaal = mijnSamung.Kanaal.ToString();
                TxtVolume = mijnSamung.Volume.ToString();
                Power = mijnSamung.Power;
                LblEigenschappen = mijnSamung.ToString();
                Afbeelding = @"images\" + mijnSamung.Afbeelding;
            }
        }

        public void VulModelOp()
        {
            if (IsValid())
            {
                if (_sony)
                {
                    mijnSony.Power = Power;
                    mijnSony.Kanaal = int.Parse(TxtKanaal);
                    mijnSony.Volume = int.Parse(TxtVolume);
                }
                else
                {
                    mijnSamung.Power = Power;
                    mijnSamung.Kanaal = int.Parse(TxtKanaal);
                    mijnSamung.Volume = int.Parse(TxtVolume);
                }
            }
        }

        public TVViewModel()
        {
            VulViewModelOp();

            Sony = true;

        }
        public string LblEigenschappen
        {
            get { return _lblEigenschappen; }
            set
            {
                _lblEigenschappen = value;
                RaisePropertyChanged("LblEigenschappen");
            }
        }

        public string TxtVolume
        {
            get { return _txtVolume; }
            set
            {
                _txtVolume = value;
                RaisePropertyChanged("TxtVolume");
            }
        }

        public string TxtKanaal
        {
            get { return _txtKanaal; }
            set
            {
                _txtKanaal = value;
                RaisePropertyChanged("TxtKanaal");
            }
        }


        public bool Power
        {
            get { return _Power; }
            set
            {
                _Power = value;
                RaisePropertyChanged("Power");

            }
        }

        public string Afbeelding
        {
            get { return _afbeelding; }
            set
            {
                _afbeelding = value;
                RaisePropertyChanged("Afbeelding");
            }
        }

        public bool Samsung
        {
            get { return _samsung; }
            set
            {

                VulModelOp();

                _samsung = value;
                VulViewModelOp();

            }
        }
        public bool Sony
        {
            get { return _sony; }
            set
            {
                VulModelOp();

                _sony = value;
                VulViewModelOp();

            }
        }

        public override string this[string columnName]
        {
            get
            {
                string result = null;
                if (columnName == "TxtKanaal")
                {
                    double conversie = 0;
                    if (!double.TryParse(TxtKanaal, out conversie))
                    {
                        result = "Geef een numerieke waarde in";

                    }
                }
                if (columnName == "TxtVolume")
                {
                    double conversie = 0;
                    if (!double.TryParse(TxtKanaal, out conversie))
                    {
                        result = "Geef een numerieke waarde in";

                    }
                }
                if (string.IsNullOrEmpty(result))
                {
                    _errors.Remove(columnName);
                }
                else
                {
                    _errors.Remove(columnName);
                    _errors.Add(columnName, result);
                }
                return result;

            }

        }
    }
}
