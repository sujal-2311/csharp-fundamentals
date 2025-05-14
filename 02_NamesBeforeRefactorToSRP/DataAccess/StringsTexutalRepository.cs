global using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NamesBeforeRefactorToSRP.DataAccess;

class StringsTexutalRepository
{
    private static readonly string Separator = Environment.NewLine;
    public List<string> Read(string filepath)
    {
        var fileContents = File.ReadAllText(filepath);
        return fileContents.Split(Separator).ToList();
    }

    public void Write(string filepath, List<string> strings)
    {
        File.WriteAllText(filepath, string.Join(Separator, strings));
    }
}
