using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NutriManager
{
    public class Ingredients
    {
        #region Fields

        private int _ID;
        private string _LIB;
        private int _QTE;
        private string _QTELIB;

        #endregion

        #region Properties

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string LIB
        {
            get { return _LIB; }
            set { _LIB = value; }
        }

        public int QTE
        {
            get { return _QTE; }
            set { _QTE = value; }
        }

        public string QTELIB
        {
            get { return _QTELIB; }
            set { _QTELIB = value; }
        }

        #endregion

        #region Constructor

        public Ingredients(int id, string lib = "Nouvel ingrédient", int qte = 0, string qtelib = "")
        {
            _ID = id;
            _LIB = lib;
            _QTE = qte;
            _QTELIB = qtelib;
        }

        public Ingredients()
        {
        }

        #endregion
    }
}
