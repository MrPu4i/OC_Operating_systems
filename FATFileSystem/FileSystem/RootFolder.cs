using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FileSystem
{
    internal class RootFolder : Folder
    {
        public RootFolder(string name, Folder parent = null) : base(name, parent) //parent может быть null
        {
            //Разершаем parent быть null
        }

        public override void FindFullPath(Folder folder)
        {
            FullPath = Name; //Это весь путь корневой папки
        }
    }
}
