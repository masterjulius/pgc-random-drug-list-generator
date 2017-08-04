using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomDrugTest
{
    public static class Global
    {
        public static string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_random_drug_test;User ID=sa;Password=p@ssw0rd";

        public static string user_id { get; set; }

        /*
         * 1 = Add
         * 2 = Edit
         * 3 = Import
        */
        public static int empID { get; set; }
        public static Int16 actionMode { get; set; }

        public static string testWintesses { get; set; }
        public static string testGeneratedBy { get; set; }

        /* Print Variabe */
        public static int print_test_id { get; set; }

        /* Number of Persons to be Generated */
        public static int personToGenerateCout { get; set; }

    }
}
