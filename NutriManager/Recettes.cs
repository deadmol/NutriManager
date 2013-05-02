using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NutriManager
{
    class Recettes
    {
        #region Fields

        private int _ID;
        private string _TITRE;
        private string _DETAILS;
        private TimeSpan _TPSPREPA;
        private TimeSpan _TPSCUISSON;
        private int _NBPERS;

        #endregion

        #region Properties

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string TITRE
        {
            get { return _TITRE; }
            set { _TITRE = value; }
        }

        public string DETAILS
        {
            get { return _DETAILS; }
            set { _DETAILS = value; }
        }

        public TimeSpan TPSPREPA
        {
            get { return _TPSPREPA; }
            set { _TPSPREPA = value; }
        }

        public TimeSpan TPSCUISSON
        {
            get { return _TPSCUISSON; }
            set { _TPSCUISSON = value; }
        }

        public int NBPERS
        {
            get { return _NBPERS; }
            set { _NBPERS = value; }
        }

        #endregion

        #region Constructor

        public Recettes()
        {
            _ID = 0;
            _TITRE = "";
            _DETAILS = "";
            _TPSPREPA = new TimeSpan();
            _TPSCUISSON = new TimeSpan();
            _NBPERS = 0;
        }

        #endregion
    }
}
