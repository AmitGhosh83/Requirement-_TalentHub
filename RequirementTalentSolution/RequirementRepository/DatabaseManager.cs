using RequirementDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace RequirementRepository
{
    public class DatabaseManager
    {
        private static readonly RequirementsContext _context;
       //Intialize a DatabaseContext and open a DB connection
        static DatabaseManager()
        {
            _context = new RequirementsContext();
        }

        //Use the Get Accessor to provide the context to consumers
        public static RequirementsContext Instance
        {
            get
            {
                return _context;
            }
        }
    }
}
