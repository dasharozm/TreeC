using DocumentFormat.OpenXml.Office2010.Excel;
using Nest;
using System;
using System.Collections.Generic;


public class FamilyTree
{
    private object? personName;
    private object? gender;
    private object? dateOfBitrh;
    private object? father;
    private object? mother;
    private object? maritalStatus;

    public static void Main(string[] args)
    { 
             
        /*void info(FamilyTree familyTree)
        {
            int id;
            string personName;
            string gender;
            string dateOfBitrh;
            string mother;
            string father;
            string maritalStatus;
            string partner;

            Console.WriteLine();
            Console.WriteLine("ФИО: {0}", familyTree.personName);
            Console.WriteLine("Пол: {0}", familyTree.gender);
            Console.WriteLine("Дата рождения: {0}", familyTree.dateOfBitrh);
            Console.WriteLine("Мать: {0}", familyTree.mother);
            Console.WriteLine("Отец: {0}", familyTree.father);
            Console.WriteLine("Семейное положение: {0}", familyTree.maritalStatus);
        }*/
    
        List<People> tree = new(membersOfFamily());

        People user = new People();
        Console.WriteLine("1 - Романов Николай Аександрович");
        Console.WriteLine("2 - Романова Александра Федоровна");
        Console.WriteLine("3 - Романова Ольга Николаевна");
        Console.WriteLine("4 - Романова Татьяна Николаевна");
        Console.WriteLine("5 - Романова Мария Николаевна");
        Console.WriteLine("6 - Романова Анастасия Николаевна");
        Console.WriteLine("7 - Романов Алексей Николаевич");
        Console.WriteLine("8 - Романов Александр Александрович");
        Console.WriteLine("9 - Романова Мария Федоровна");
        Console.WriteLine("10 - Гессенский Людвиг");
        Console.WriteLine("11 - Гессенская Алиса");
        Console.WriteLine("12 - Романов Александр Аександрович");
        Console.WriteLine("13 - Романов Георгий Аександрович");
        Console.WriteLine("14 - Романова Ксения Аександровна");
        Console.Write("Укажите ID человека из генеалогического древа (1-14): ");
        int id = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < tree.Count; i++)
        {
            if (id == tree[i].id)
            {
                tree[i].info();
                user = tree[i];
                if (tree[i].partner.Equals("Не замужем") || (user.partner.Equals("Не женат")))
                {
                    Console.WriteLine("Нет спутника жизни");
                }
                else
                {
                    if (tree[i].gender.Equals("Женский"))
                    {
                        Console.WriteLine("Муж : {0}", tree[i].partner);
                    }
                    else
                    {
                        Console.WriteLine("Жена : {0}", tree[i].partner);
                    }
                }
            }
        }
        Console.WriteLine();

        List<People> children = new List<People>();
        for (int i = 0; i < tree.Count; i++)
        {
            if (user.personName != tree[i].personName && user.dateOfBitrh != tree[i].dateOfBitrh)
            {
                if (user.mother.Equals(tree[i].mother) || user.father.Equals(tree[i].father))
                {
                    if (tree[i].gender.Equals("Женский"))
                    {
                        Console.WriteLine("Сестра: {0}", tree[i].personName);
                    }
                    if (!tree[i].gender.Equals("Мужской"))
                    {
                    }
                    else
                    {
                        Console.WriteLine("Брат: {0}", tree[i].personName);
                    }
                }
                if (user.partner.Equals(tree[i].personName))
                {
                    if (user.gender.Equals("Мужской"))
                    {
                        Console.WriteLine("Теща: {0}", tree[i].mother);
                        Console.WriteLine("Тесть: {0}", tree[i].father);
                    }
                    if (user.gender.Equals("Женский"))
                    {
                        Console.WriteLine("Свекровь: {0}", tree[i].mother);
                        Console.WriteLine("Свекор: {0}", tree[i].father);
                    }
                }
                if (!user.personName.Equals(tree[i].father) && !user.personName.Equals(tree[i].mother))
                {
                    continue;
                }
                children.Add(tree[i]);
            }
        }

        

    }

    private static IEnumerable<People> membersOfFamily()
    {
        throw new NotImplementedException();
    }
}

