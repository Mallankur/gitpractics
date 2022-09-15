using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleminpython
{
    internal class Program
    {
        public List<int> merge (List<int>  s1 , IList<int> s2)
        {
            var finallist = s1.Concat(s2).ToList();


            finallist.Sort();
            foreach (var item in finallist)
            {
                Console.WriteLine( item);

            }

            return finallist;


        }
              
            

            
                

            
                
            


        
                    



        static void Main(string[] args)
        {

            //Console.WriteLine("Enter the vlue in pound ");
            //var pound= double.Parse(Console.ReadLine());
            //var kg =  pound/2.2;
            //Console.WriteLine("your convert answer is " + kg);
            // Problem 02
            //Console.WriteLine("Enter your first number :");
            //var num1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your  second number :");
            //var num2= double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your third number :");
            //var num3= double.Parse(Console.ReadLine());
            //var total = num1 + num2 + num3;
            //Console.WriteLine("This is your total number: " + total);
            //var avarge = total / 3;
            //Console.WriteLine("The avarge of number of the number is"+ avarge );
            // problem 03
            //var i = 8;
            //while (i < 89)
            //{
            //    Console.WriteLine(i);
            //    i += 3;
            //}
            //for (int i = 6; i < 89; i++)
            //{
            //    i += 2;
            //    Console.WriteLine(i);
            //Problem 04 
            //Console.WriteLine("Enetr your Name :");
            //var name= Console.ReadLine();
            //Console.WriteLine("How many times you want your name e");
            //var not = int.Parse(Console.ReadLine());
            //for (int i = 0; i < not; i++)
            //{
            //    Console.WriteLine(name);
            //}
            // Problem 05  (Not qilified)
            //var astric ="*" ;
            //for (int i = 0; i < 4; i++)
            //{
            //    astric =astric + "*";
            //    ;

            //}
            //Console.Write(astric);
            // problem no 6
            //Console.WriteLine("Enter  your gusse number :");
            //var guessnumber = Int32.Parse(Console.ReadLine());
            //var randomnumber = new Random().Next(1, 10);
            //if (randomnumber == guessnumber)
            //{
            //    Console.WriteLine("congratultion your guessnumber is right");
            //}
            //else Console.WriteLine("Better luck next times");
            //Problem 07
            //Console.WriteLine("Enter your first number :");
            //var num1= double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number :");
            //var num2= double.Parse(Console.ReadLine());
            //var abs = (Math.Abs(num1 - num2));
            //if (abs <=  0.001)
            //{
            //    Console.WriteLine("Number is closed ");
            //}
            //else
            //{

            //    Console.WriteLine("Number is not closed");
            //}
            //Problem 08
            //Console.WriteLine("Enter your Name");
            //var name = "ankurmall";
            //Console.WriteLine(name.Contains('a'));
            //Console.WriteLine(name.Contains('e'));
            //Console.WriteLine(name.Contains('i'));
            //Console.WriteLine(name.Contains('o'));
            //Console.WriteLine(name.Contains('u'));

            //name.Contains(a);
            //var lst = new List<string>();
            //var name = Console.ReadLine().Split(' ');
            //foreach (var item in name)
            //{
            //    if()

            //}
            //if(name.Contains(a)) \
            // Problem 09 ...........................................Unsolved
            //var strfinal = new string();
            //var str= "ABCD";
            //var str2 = "abcd";
            //foreach (var i in str ) 
            //{
            //    foreach (var j in str2)
            //    {
            //        Console.WriteLine((i+j));


            //    }
            //}

            //Console.WriteLine("Enter your string");
            //var str1 = Console.ReadLine();
            //Console.WriteLine("Enter your string");
            //var str2 = Console.ReadLine();
            //if (str1.Length != str2.Length)
            //{
            //    Console.WriteLine("String are different length");
            //}
            //
            //Console.WriteLine("Enter your Number");
            //var number = int.Parse(Console.ReadLine());
            //Console.WriteLine(number-------------------------------incomplete
            //PROBLEM 12
            // Console.WriteLine("Genrate your number");
            // var lst= new List<int>();
            //for (int i = 0; i < 20; i++)
            //{

            //    var num = new Random().Next(1, 20);


            //    lst.Add(num);
            //}
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);


            //}
            //var lst = new List<int>();
            //while(lst.Count < 3)
            //{
            //    var ran = new Random().Next(1, 20);
            //    if (lst.Contains(ran))
            //    {
            //        Console.WriteLine("the number is already is there");
            //        continue;
            //    }  
            //    lst.Add(ran);
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    var rand=new Random().Next(1,5);
            //    if()
            //    lst.Add(rand);

            //}

            //    Console.WriteLine(lst);
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);

            //}
            //// PROBLEM 13
            //var FACTOR = new List<int>();
            //Console.WriteLine("Enter your number: ");
            //var number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <number ; i++)
            //{
            //    FACTOR.Add(number/i);

            //}
            //FACTOR.Reverse();


            //foreach (var item in FACTOR)
            //{
            //    Console.WriteLine(item);

            //}

            // Problem 14 ...............................continue prob 15...........................
            //Console.WriteLine("Enter your string of interger");
            //var lst2= new List<string>();
            //var lst = Console.ReadLine().Split(',');
            //for (int i = 0; i < lst.Length; i++)
            //{
            //    if (lst2.Contains(lst[i]))
            //    {
            //        Console.WriteLine("sry you have already this number ");

            //        continue;
            //    }
            //    lst2.Add(lst[i]);




            //}
            //foreach (var item in lst2)
            //{
            //    Console.WriteLine(item);

            //}
            //Question 16CO,PLETED 
            //Console.WriteLine("Enter the value  ");


            // QUESTION  

            //Console.WriteLine("enter the first value ");
            //var x = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the value of y ");
            //var y = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(cl.sum_degits(x, y));

            //question 17
            //Console.WriteLine("Enter the value of list");
            //var x = Int32.Parse(Console.ReadLine());
             var cl = new Program();
            //Console.WriteLine(cl.is_sorted (new List<int> {12,15,16,20}));
            // Problem 21
            //Console.WriteLine("Enter the value of x ");
            //var x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the value of n ");
            //var n = int.Parse(Console.ReadLine());
            //Console.WriteLine(cl.root(x,n));
            // 
            // Console.WriteLine(cl.merge(new List<int> { 2, 4, 6 }, new List<int> { 1, 3, 5 }));
            // PLAY WITH FLES 
            var path = @"c;\somefile.jpg";
            File.Copy("c:\\temp\\myfilr.jpg", "c:\\temp\\myfile.jpg",true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
                    var cont =File.ReadAllText(path);
            var fileinfo = new FileInfo(path);


            Console.ReadLine();



            
            




        }
    }
}
