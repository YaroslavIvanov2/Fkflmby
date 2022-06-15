using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom_AladinSclad.DB
{
    public class DataBase
    {
        private static WSREntities1 _context;
        public static WSREntities1 GetContext()
        {
            if (_context == null)
                _context = new WSREntities1();
            return _context;
        }
    }
}
