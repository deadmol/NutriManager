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
        private string _NOM;
        private int _PREPARATION;
        private int _CUISSON;
        private int _NBPERS;    
        private string _DETAILS;

        #endregion

        #region Properties

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string NOM
        {
            get { return _NOM; }
            set { _NOM = value; }
        }

        public int PREPARATION
        {
            get { return _PREPARATION; }
            set { _PREPARATION = value; }
        }

        public int CUISSON
        {
            get { return _CUISSON; }
            set { _CUISSON = value; }
        }

        public int NBPERS
        {
            get { return _NBPERS; }
            set { _NBPERS = value; }
        }

        public string DETAILS
        {
            get { return _DETAILS; }
            set { _DETAILS = value; }
        }
        #endregion

        #region Constructors

        public Recettes(int id, string nom = "", string details = "", int preparation = 0, int cuisson = 0, int nbpers = 0)
        {
            _ID = id;
            _NOM = nom;
            _DETAILS = details;
            _PREPARATION = preparation;
            _CUISSON = cuisson;
            _NBPERS = nbpers;
        }

        public Recettes()
        {
        }

        #endregion
    }
}
