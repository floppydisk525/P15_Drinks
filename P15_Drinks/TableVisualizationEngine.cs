using ConsoleTableExt;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_Drinks
{
    internal class TableVisualizationEngine
    {
        //Console.Clear();  //add this before the showtable call.  didn't want to add it cuz never did that befor and would result
        //  in a confusing showtable method.  
        public static void ShowTable<T>(List<T> tableData, [AllowNull] string tableName) where T : class
        {
            if (tableName == null)
                tableName = "";

            Console.WriteLine("\n\n");

            ConsoleTableBuilder
                .From(tableData)
                .WithTitle(tableName)
                .ExportAndWriteLine();
            Console.WriteLine("\n\n");
        }
    }
}
