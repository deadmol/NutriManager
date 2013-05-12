using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NutriManager
{
    public class Categories
    {
        #region Fields

        private int _ID;
        private string _NOM;
        private Categories _PARENT;

        #endregion

        #region Properties

        public string NOM
        {
            get { return _NOM; }
            set { _NOM = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public Categories PARENT
        {
            get { return _PARENT; }
            set { _PARENT = value; }
        }

        #endregion

        #region Constructors

        public Categories()
        {
            
        }

        public Categories(int InId = 0, string InNom = "Nouvelle catégorie", Categories InParent = null)
        {
            _ID = InId;
            _NOM = InNom;
            _PARENT = InParent;
        }

        #endregion
    }
}
