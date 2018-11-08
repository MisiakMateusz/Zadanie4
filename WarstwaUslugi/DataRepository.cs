using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using System.Windows;
using Prism.Commands;


namespace WarstwaUslugi
{
    public class DataRepository
    {
        private static DataBaseAdventureWorksDataContext dataContex = new DataBaseAdventureWorksDataContext();

        public static DataBaseAdventureWorksDataContext DataContex { get => dataContex; set => dataContex = value; }

        //public static void CreatePreson(Person p)
        //{
        //    dataContex.Person.InsertOnSubmit(p);
        //    try
        //    {
        //        dataContex.SubmitChanges();
        //    }
        //    catch(Exception e)
        //    {

        //    }
        //}

    }
}
