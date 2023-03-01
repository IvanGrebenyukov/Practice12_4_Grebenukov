using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11_12_Zadanie4
{
    public class Athlete
    {
        private string name;
        private string surname;
        private string lastname; //Отчетсво
        private string gender;
        private DateTime dateOfBirthday;
        private double heigth;
        private double weight;
        private string typeSport;
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
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public DateTime DateOfBirthday
        {
            get { return dateOfBirthday; }
            set { dateOfBirthday = value; }
        }
        public double Height
        {
            get { return heigth; }
            set { heigth = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string TypeSport
        {
            get { return typeSport; }
            set { typeSport = value; }
        }

        //Метод вывода информации о спортсмене
        public string InfoAthlet()
        {
            return @$"Имя: {name}
Фамилия: {surname}
Отчество: {lastname}
Пол: {gender}
Дата рождения: {dateOfBirthday}
Рост: {heigth}
Вес: {weight}
Вид спорта: {typeSport}";
        }

        //Метод расчета идеального веса по формуле Брока
        public double CalculateBrok()
        {
            double perfect_weight = 0;
            if(DateTime.Now.Year - dateOfBirthday.Year < 40)
            {
                perfect_weight = heigth - 110;
            }
            else if(DateTime.Now.Year - dateOfBirthday.Year > 40)
            {
                perfect_weight = heigth - 100;
            }
            return perfect_weight;
        }


        //Метод расчета идеального веса по формуле Куппера
        public double CalculateCouper()
        {
            double perfect_weight = 0;
            if(gender == "Женский")
            {
                perfect_weight = (heigth * 3.5 / 2.54 - 108) * 0.453;
            }
            else if(gender == "Мужской")
            {
                perfect_weight = (heigth * 4 / 2.54 - 128) * 0.453;
            }
            return Math.Round(perfect_weight,2);
        }

        //Метод расчета идеального веса по формуле Моххамеда
        public double CalculateMoxxamed()
        {
            double perfect_weight = heigth * heigth * 0.00225;
            return Math.Round(perfect_weight, 2);
        }


    }
}
