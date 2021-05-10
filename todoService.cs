using ListGenericToDoUygulama.database;
using ListGenericToDoUygulama.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenericToDoUygulama.businessService
{
    public class todoService
    {
        public int kayitKontrol()
        {
            return sanalDatabase.todoTablo.Count;
        }

        public List<todo> kayitListe()
        {
            return sanalDatabase.todoTablo;
        }

        public int kayitYeni(todo data)
        {
            try
            {
                sanalDatabase.todoTablo.Add(data);
                return 1;

            }

            catch(Exception ex)
            {
                return 0;
            }


            
        }





    }
}
