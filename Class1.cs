using System;
using System.Collections.Generic;
using System.Text;

namespace prak14
{
    public class Informations
    {
        private string name;
        private string surname;
        private string patronymic;
        private string age;
        private string weight;

        public Informations(string name, string surname, string patronymic, string age, string weight)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.age = age;
            this.weight = weight;
        }
        public Informations()
        {

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
