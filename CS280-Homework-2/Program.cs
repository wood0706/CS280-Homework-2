using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            string name = "";

            string number = "";

            string abilities = "";

            float height = 0.0f;

            float weight = 0.0f;

            string category = "";

            string gender = "";
            Console.WriteLine("請輸入一隻Pokemon:");

            Console.Write("名字: ");

            pokemon.Name = Console.ReadLine();

            Console.Write("編號: ");

            pokemon.Number = Console.ReadLine();

            Console.Write("能力: ");

            pokemon.Abilities = Console.ReadLine();

            Console.Write("身高: ");

            try
            {
                pokemon.Height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤，請輸入數字");

                Console.WriteLine("錯誤訊息:\n" + e.ToString());

                return;
            }

            Console.Write("體重: ");

            try
            {
                pokemon.Weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤，請輸入數字");

                Console.WriteLine("錯誤訊息:\n" + e.ToString());

                return;
            }

            Console.Write("類別: ");

            pokemon.Category = Console.ReadLine();

            Console.Write("性別: ");

            pokemon.Gender = Console.ReadLine();

            pokemon.Name = name;

            pokemon.Number = number;

            pokemon.Abilities = abilities;

            pokemon.Height = height;

            pokemon.Weight = weight;

            pokemon.Category = category;

            pokemon.Gender = gender;

            Console.WriteLine("輸入資訊正確");
        }
    }
}