using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibOperLog
{
    public class CHandLog
    {
        private DataTable l_table = null;
        private DataSet l_ds = new DataSet();
        public CHandLog()
        {
            l_table = new DataTable("Log");


            DataColumn l_column = new DataColumn();
            l_column.DataType = Type.GetType("System.Guid");
            l_column.ColumnName = "ID";
            l_column.ReadOnly = true;
            l_column.Unique = true;
            l_table.Columns.Add(l_column);

            
            l_column = new DataColumn();
            l_column.DataType = Type.GetType("System.DateTime");
            l_column.ColumnName = "Date";
            l_column.ReadOnly = true;
            l_column.Unique = true;
            l_table.Columns.Add(l_column);

            l_column = new DataColumn();
            l_column.DataType = Type.GetType("System.UInt32");
            l_column.ColumnName = "Code";
            l_column.ReadOnly = true;
            l_column.Unique = true;
            l_table.Columns.Add(l_column);

            l_column = new DataColumn();
            l_column.DataType = Type.GetType("System.String");
            l_column.ColumnName = "Description";
            l_column.ReadOnly = true;
            l_column.Unique = true;
            l_table.Columns.Add(l_column);

            l_column = new DataColumn();
            l_column.DataType = Type.GetType("System.Int16");
            l_column.ColumnName = "Type";
            l_column.ReadOnly = true;
            l_column.Unique = true;
            l_table.Columns.Add(l_column);

            l_ds.Tables.Add(l_table);
            
        }
        public void AddLine(DataSet log_values)
        {
            string l_file = "LogFile.xml";
            FileStream l_Stream = new FileStream(l_file,FileMode.Append);
            log_values.WriteXml(l_Stream);
        }
        public void AddLine(long code, string message)
        {
            DataRow l_row = l_table.NewRow();
            l_row["ID"] = new System.Guid();            
            l_row["Date"] = DateTime.Now;
            l_row["Code"] = code;
            l_row["Description"] = message;
            l_row["Type"] = 2;

            l_table.Rows.Add(l_row);
        }

        public void Flush()
        {
            string l_file = "LogFile.xml";
            FileStream l_Stream = new FileStream(l_file, FileMode.Append);
            l_ds.WriteXml(l_Stream);
        }
    }
}

