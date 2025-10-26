using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_Zadanie_3_Virtual_Memory
{
    internal class VirtualMemory //Наша виртуальная память
    {
        int VirtMemorySize = 10000; //Размер виртуальной памяти = 10гб
        List<string> virtAdresses; //пространство виртуальных адресов для процессов
        int pageSize; //размер страницы виртуальной памяти



        public void MakeMasFromVirt() //Метод, формирующий массив из ячеек виртуальной памяти
        {
        }
        public /*адрес реальной памяти*/void VirtAddrToRealAddr(/*адрес виртуальной памяти*/)//Метод, преобразующий виртуальный адрес в реальный адрес в оперативной памяти.
        {
            //return address реальной памяти
        }
        public void GetRAMAddr()
        {
            //доступ к оперативной памяти
        }

        public /*адрес вирт памяти*/void RealAddrToVirtAddr(/*адрес реальной памяти*/)//Наоборот
        {
            //return address вирт памяти
        }
        public void GetVirtAddr()
        {
            //доступ к виртуальной памяти ??? мы же и так здесь
        }

        public void SwapPage() //замещение страницы
        {
            PageOut();
        }

        public void PageOut() //помечает страницы в таблице страниц как вытесненную
        {
            
        }

        public void Init(/*Размер оперативной памяти в страницах*/) //инициализирует всю систему управления виртуальной памятью.
                           //Вызывается в тот момент, когда заканчивается место в оперативной памяти.
        {
            
        }
    }
}
