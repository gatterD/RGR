using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RGR.Страница_сорта
{
    public class Export
    {
        private DataTable data;
        public Export() { }

        public Export(DataTable dataTable) 
        {
            data = dataTable;
        }
        public void createWord()
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            word.Application.Documents.Add(Type.Missing);

            Microsoft.Office.Interop.Word.Table table = word.Application.ActiveDocument.Tables.Add(word.Selection.Range, data.Rows.Count + 1, data.Columns.Count, Type.Missing, Type.Missing);
            table.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
            table.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;

            for (int i = 0; i < data.Columns.Count; i++)
            {
                table.Cell(1, i + 1).Range.Text = data.Columns[i].ColumnName;
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    table.Cell(i + 2, j + 1).Range.Text = data.Rows[i][j].ToString();
                }
            }

            word.Visible = true;
        }
    }
}
