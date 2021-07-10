using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_Foure_Array_String
{
    class com_Str
    {
        public static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "csharp";
            string s4 = "mello";

            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s2, s3));
            Console.WriteLine(string.Compare(s3, s4));
        }
    }
}
/*
    public static void Main(string[] args)    
        {    
            string s1 = "hello";    
            string s2 = "hello";    
            string s3 = "csharp";  
            string s4 = "mello";  
        
            Console.WriteLine(string.CompareOrdinal(s1,s2));   
            Console.WriteLine(string.CompareOrdinal(s1,s3));   
            Console.WriteLine(string.CompareOrdinal(s1,s4));   
        }    


public static void Main(string[] args)    
        {    
            string s1 = "hello";    
            string s2 = "hello";    
            string s3 = "csharp";  
            Console.WriteLine(s1.CompareTo(s2));   
            Console.WriteLine(s2.CompareTo(s3));   
        }    

 */