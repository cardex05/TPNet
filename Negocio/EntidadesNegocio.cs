using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class EntidadesNegocio
    {
        private int _ID; 
        private int _Estado;
    
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        public int Estado
        {
            get
            {
               return _Estado;
            }
            set
            {
                _Estado = value;
            }
        }

        public void EntidadNegocio()
        {
            throw new System.NotImplementedException();
        }
    }
}
