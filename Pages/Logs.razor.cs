using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace BlazorEx.Pages
{
    public class GetText : ComponentBase
    {
        public int i = 0;
        public int index = 0;
        public int indexView = 1;
        public string str { get; set; }
        static string path = @".\wwwroot\Канал_03.CE 303";
        public string[] text = File.ReadAllLines(path, CodePagesEncodingProvider.Instance.GetEncoding(1251));
    }
}
