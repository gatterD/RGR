using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace RGR
{
    public class Export
    {
        private FileInfo _file_info;

        public Export() { }

        public Export(string file_name)
        {
            if(File.Exists(file_name))
                _file_info = new FileInfo(file_name);
            else
                throw new ArgumentException("Файл не найден.");
        }

        internal bool process(Dictionary<string, string> items)
        {
            Word.Application app = null;

            try
            {
                app = new Word.Application();

                Object file = _file_info.FullName;
                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach(var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing, MatchCase: false,
                        MatchWholeWord: false, MatchWildcards: false,
                        MatchSoundsLike: missing, MatchAllWordForms: false,
                        Forward: true, Wrap: wrap, Format: false,
                        ReplaceWith: missing, Replace: replace);
                }

                string value = "";
                items.TryGetValue("Name", out value);

                Object new_file_name = Path.Combine(_file_info.DirectoryName,
                    value + " " + DateTime.Now.ToString("yyMMdd HHmmss"));
                app.ActiveDocument.SaveAs2(new_file_name);
                app.ActiveDocument.Close();
                

                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                if(app != null)
                    app.Quit();
            }
            return false;
        }
    }
}
