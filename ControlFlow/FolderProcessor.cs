using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class FolderProcessor
    {
        public static void DisplayParentNames_While(string filePath)
        {
            var folder = new DirectoryInfo(Path.GetDirectoryName(filePath)!);

            while (folder != null)
            {
                Console.WriteLine(folder.Name);
                folder = folder.Parent;
            }
        }

        public static IEnumerable<string> EnumerateParentNames_While(string filePath)
        {
            var folder = new DirectoryInfo(Path.GetDirectoryName(filePath)!);
            while (folder != null)
            {
                yield return folder.Name;
                folder = folder.Parent;
            }

        }

        public static IEnumerable<string> EnumerateParentNames_For(string filePath)
        {
            for (var folder = new DirectoryInfo(Path.GetDirectoryName(filePath)!); folder != null; folder = folder.Parent)
            {
                yield return folder.Name;
            }
        }

        public static IEnumerable<string> EnumerateParentNames_DoWhile(string filePath)
        {
            var folder = new DirectoryInfo(Path.GetDirectoryName(filePath)!);
            do
            {
                yield return folder.Name;
                folder = folder?.Parent;
            } while (folder != null);
        }
    }
}
