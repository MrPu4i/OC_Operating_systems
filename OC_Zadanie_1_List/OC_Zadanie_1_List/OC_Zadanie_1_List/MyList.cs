using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_Zadanie_1_List
{
    internal class MyList
    {
        List<int> list = new List<int>();

        //Добавить 
        public void AddNum(int num)
        {
            list.Add(num);
        }

        //Удалить первый элемент
        public void DeleteFirst()
        {
            list.RemoveAt(0);
        }

        //удалить выбранный элемент
        public void DeleteAt(int ind)
        {
            list.RemoveAt(ind);
        }

        //Удалить все элементы списка
        public void ClearList()
        {
            list.Clear();
        }

        //Сортировка
        public void SortList()
        {
            list.Sort();
        }

        public List<int> GetList()
        {
            return list;
        }
    }
}
