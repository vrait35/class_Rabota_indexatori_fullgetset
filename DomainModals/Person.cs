using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModals
{
    public class Person
    {
        private string [] ImagesUrl { get; set; }
        public string FullName { get; set; }

        /*
         мод.доступа(паблик) тип имя{
         get{
         telo;
         return имя_переменной
         }
         set{
         telo;
         имя_переменной=value;// value - спец.слово(аргумент функции)
            }
             */

           // public string[] ImagesUrl { get; set; }


             public string this[int index]
        {
            get
            {
                return ImagesUrl[index];
            }
            set
            {
                ImagesUrl[index] = value;
            }
        }
        private string middleName;
        public string MiddleName
        {
            get
            {
                Console.WriteLine("получено значение middleName");
                //age.HasValue();
                return middleName;
            }
            set {
                Console.WriteLine("задано значение middleName");
                middleName = value;
            }
        }
        //primer starogo podhoda
        private int age;
        public int GetAge() { return age; }
        public void SetAge(int a) { age = a; }

    }
}
