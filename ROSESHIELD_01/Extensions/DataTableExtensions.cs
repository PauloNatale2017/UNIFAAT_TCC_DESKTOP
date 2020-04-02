using ROSESHIELD.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ROSESHIELD_01.Extensions
{
    public  class DataTableExtensions
    {
        List<ExcelImportado> list = new List<ExcelImportado>();
        public int totals { get; set; }
        public int contadot { get; set; }
        public  List<T> ToDinamic<T>(DataTable dt)
        {
          

           

            List<T> data = new List<T>();
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

           

            foreach (DataRow item in dt.Rows)
            {
                var itens = item;
                foreach (DataColumn dr in item.Table.Columns)
                {
                    var drs = dr;
                    foreach (PropertyInfo propertyinfo in temp.GetProperties())
                    {
                        var propertyes = propertyinfo;
                    }
                }


                //        T dataa = GetItem<T>(item);
                //data.Add(dataa);
            }
            return data;
        }

        public  T GetItem<T>(DataRow row)
        {
            int total = 18;
        
            int count = 0;
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            

            foreach (DataColumn dr in row.Table.Columns)
            {
                foreach (PropertyInfo item in temp.GetProperties())
                {

                    if (contadot == row.Table.Columns.Count)
                        break;

                    contadot = contadot + 1;

                    if (total == count)
                        break;

                    var retornos = item.Name == null ? "null" : item.Name;
                    if(retornos != "null")
                    {
                        item.SetValue(obj, row[dr.Table.Columns[count].ColumnName], null);
                        count++;
                    }

                    if (count == 17)
                    {
                        count = 0;
                        break;
                    }

                    continue;
                }

            }
            return obj;

        }


    }
}
