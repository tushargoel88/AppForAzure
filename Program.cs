using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleElemetnArray();
            //RecurisiveCheck(879);
            //int value = 10;
            //int sum = 0;
            //int addition = 0;
            //for (int i = value - 1; i >= 2; i--)
            //{
            //    if (i % 3 == 0 | i % 5 == 0)
            //    {                    
            //        addition += sum + i;
            //    }
            //}


            //string str = "How can mirrors be real if our eyes aren't real";
            //str = Thread.CurrentThread.CurrentCulture.TextInfo. ToTitleCase(str.ToLower());
            //int[] ary = new int[] { 1, 2, 1, 2, 1, 1 };
            //var xx = ReturnSecondLargestNumber(ary);

            //A objA = new A();
            //B objB = new B();
            //objA = objB;
            //objA.Show();
            //Console.ReadLine();

            //string str = @"Baleno,Rim,1
            //                Wagonr,Rim,6
            //                Mercedez,Handle,5
            //                Tigor,Handle,8
            //                Benz,Rim,10
            //                Corola,Handle,20
            //                ";
            //FindProductWithLatestVersion(str);

            //var a = FindNextElement("xyz");
            //var a = FindPreviousElement("ajklmn");
            //Console.WriteLine(a);
            //Console.ReadLine();

            //int[] ary = new int[] {1,2,1,2,1,1};            
            //var x = ElementOccuredMoreThanHalf(8,ary);

            //ConvertString("a");

            //var str = ConvertVariableName("modifyVariableName");
            //Console.WriteLine(str);
            //Console.ReadLine();
        }

        /// <summary>
        /// Double the first element and move zero to end
        /// </summary>
        public static void DoubleElemetnArray()
        {
            int[] arr = { 2,2,0,4,0,8 };
            int[] newarr = new int[arr.Length];
            //int[] newinx = new int[arr.Length];
            int item;
            int index = 0;

            for (int i = 0; i < arr.Length -1; i++)
            {
                if(arr[i] != 0 && arr[i] == arr[i+1])
                {
                    item = arr[i] * 2;
                    arr[i] = item;
                    arr[i + 1] = 0;
                }
            }

            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //if (arr[i] != 0)
                //{
                //    if(index != 0)
                //    {
                //        index = i + 1;
                //    }

                //    newarr[index] = arr[i];
                //}
                if (arr[i] == 0)
                {
                    j = i;
                    break;
                }
            }

            for (int i = j+1; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[j] = arr[i];
                    j = j + 1;
                    arr[i] = 0;
                }
            }

                Console.WriteLine("Test");
        }


        /// <summary>
        /// Align array with provided index and corresponding values
        /// </summary>
        public static void AlignArray()
        {
            int[] arr = { 50,40,70,60,90};
            int[] ind = {3,0,4,1,2};
            int[] newarr = new int[arr.Length];
            int[] newinx = new int[arr.Length];
            int item;
            int index;

            for (int i = 0; i < arr.Length; i++)
            {
                index = ind[i];
                item = arr[i];

                newinx[i] = i;
                newarr[index] = item;
            }
            Console.WriteLine("TEst");
        }

        public static void RecurisiveCheck(long numm)
        {
            int num = Convert.ToInt32(numm);
            int[] digits = num.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            int sum = 0;
            if (digits.Length > 1)
            {
                for (int i = 0; i < digits.Length; i++)
                {
                    sum += digits[i];                    
                }
                RecurisiveCheck(sum);
            }
            else if (digits.Length == 1)
            {
                Console.WriteLine(digits[0]);
                Console.ReadLine();
            }
            Console.ReadLine();

        }
       
        public class A
        {
            public virtual void Show()
            {
                Console.WriteLine("Base");
                Console.WriteLine("Tes");
            }
        }

        public class B : A
        {
            public override void Show()
            {
                Console.WriteLine("Derived");
                Console.WriteLine("Really");
            }
        }

        private static int ReturnNthPrimeNumber(int n)
        {
            int numberToBeChecked = 0;
            int count = 0;
            while (true)
            {
                numberToBeChecked++;
                if (IsPrimeNumber(numberToBeChecked) == true)
                {
                    count++;
                }
                if (count == n)
                {
                    Console.WriteLine("Number is" + numberToBeChecked);
                    Console.ReadLine();
                    break;
                }
            }
            return numberToBeChecked;
        }

        /// <summary>
        /// Check if the number is prime or not
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private static bool IsPrimeNumber(int i)
        {
            int count = 0;
            for (int j = 2; j < i/2; j++)
            {
                if (i % j == 0)
                {
                    count = 1;
                    break;
                }
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method to find element occured more than once
        /// </summary>
        /// <param name="i"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int ElementOccuredMoreThanHalf(int i, int[] arr)
        {
            Array.Sort(arr);
            var intlength = (arr.Length / 2);
            var midElement = arr[intlength];

            var countofMidElement = (from x in arr where x == midElement select x).Count();
            if (countofMidElement > intlength)
            {
                return midElement;
            }
            return 0;
        }


        /// <summary>
        /// Method to print character and its count
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        //private static string ConvertString(string str)
        //{
        //    int[] arr = new int[] {};
        //    foreach (var x in str)
        //    {
        //        byte[] ax = Encoding.ASCII.GetBytes(str[x].ToString());
        //        var ay = ax[0] - 97;
        //        arr[ay] = arr[ay] + 1;
        //    }
        //    var distinctElements = str.Distinct().ToArray();



        //    int[] array = { 1, 2, 3, 4, 5, 67 };
        //    Array.Sort(array);
        //    int ele = array[0];
        //    for(int i=0; i<= array.Length; i++)
        //    {
        //        if(array[i] != ele)
        //        {
        //            return array[i];
        //        }
        //    }



        //    int count = 0;
        //     for (int x= 0; x<n; x++)
        //    {
        //        for(int y=0;y<n; y++)
        //        {
        //            int hcf = 1;
        //            int min =(x < y) ? x: y;
        //            for(int i= 1; i<=min; i++)
        //            {
        //                if(x % i==0 && y%i==0)
        //                {
        //                    hcf = i;
        //                }
        //            }
        //            if (hcf == 1)
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    return count;
        //    foreach (var item in distinctElements)
        //    {

        //    }

        //    return "true";
        //    //string newValue = String.Empty;
        //    //var distinctElements = str.Distinct().ToArray();
        //    //for (int i = 0; i < distinctElements.Count(); i++)
        //    //{

        //    //    var count = (from a in str.ToList() where a == distinctElements[i] select a).Count();
        //    //    newValue += distinctElements[i] + count.ToString();
        //    //}
        //    //return newValue;
        //}

        private static string ConvertVariableName(string inputStr)
        {
            string outStr = string.Empty;
            if(inputStr.Contains("_"))
            {
                outStr = inputStr.Replace("_", "");                
            }
            else
            {
                for (int i = 0; i < inputStr.Length -1 ; i++)
                {
                    if(Char.IsUpper(Convert.ToChar(inputStr[i])))
                    {                        
                        inputStr = inputStr.Replace(inputStr[i].ToString(), "_" + inputStr[i].ToString().ToLower());
                    }
                }
                outStr = inputStr;
            }
            return outStr;
        }

        /// <summary>
        /// Method to find next element of all characters of a string
        /// </summary>
        private static string FindNextElement(string str)
        {
            string text = string.Empty;
            char character;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i].ToString())
                {
                    case "x":
                        character = Convert.ToChar("a");
                        break;
                    case "y":
                        character = Convert.ToChar("b");
                        break;
                    case "z":
                        character = Convert.ToChar("c");
                        break;
                    default:
                        byte[] charByte = Encoding.ASCII.GetBytes(str[i].ToString());
                        int y = charByte[0] + 3;
                        character = (char)y;
                        break;
                }
                text += character.ToString();
            }
            return text;
        }

        /// <summary>
        /// Method to find previous element of all characters of a string
        /// </summary>
        private static string FindPreviousElement(string str)
        {
            string text = string.Empty;
            char character;
            for (int i = 0; i < str.Length; i++)
            {                
                switch (str[i].ToString())
                {
                    case "a" :
                        character = Convert.ToChar("x");
                        break;
                    case "b":
                        character = Convert.ToChar("y");
                        break;
                    case "c":
                        character = Convert.ToChar("z");
                        break;
                    default:
                        byte[] charByte = Encoding.ASCII.GetBytes(str[i].ToString());
                        int y = charByte[0] - 3;
                        character = (char)y;
                        break;
                }               
                text += character.ToString();
            }
            return text;
        }

        /// <summary>
        /// Method to print product name which uses latest version of part | HARMAN
        /// </summary>
        /// <param name="str"></param>
        private static void FindProductWithLatestVersion(string str)
        {
            string[] strArray = str.Split('\n');
            List<Product> list = new List<Product>();
            for (int i = 0; i < strArray.Length - 1; i++)
            {
                string[] strA = strArray[i].Split(',');
                Product product = new Product();
                product.ProductName = strA[0];
                product.PartName = strA[1];
                product.VersionName = Convert.ToInt32(strA[2]);
                list.Add(product);
            }
            var SortedList = list.GroupBy(o => o.PartName).ToList();

            foreach (var x in SortedList)
            {
                var y = x.OrderByDescending(n => n.VersionName).ToList();
                var b = (from bb in y select bb).FirstOrDefault();

                var product = (from vv in list where vv.PartName == x.Key && vv.VersionName == b.VersionName select vv.ProductName).FirstOrDefault();
                if (!String.IsNullOrEmpty(product))
                {
                    Console.WriteLine(product);
                    Console.ReadLine();
                }
            }

        }

        private static int ReturnSecondLargestNumber(int[] inpu)
        {
            Array.Sort(inpu);
            Array.Reverse(inpu);
            var x = 0;
            var y = 0;
            for (int i = 0; i < inpu.Length - 1; i++)
            {
                x = inpu[i];
                y = inpu[i + 1];
                if(x == y)
                {
                    continue;
                }
                else if (y < x)
                {
                    return y;               
                }
            }
            return -1;
        }

    }

    public class Product
    {
        public string ProductName { get; set; }
        public string PartName { get; set; }
        public int VersionName { get; set; } 
    }
}

