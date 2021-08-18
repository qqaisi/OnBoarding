using System;
namespace WordBucket
{
    public class Program
    {

        public static void WordBucket(string sentence, int count){

            string[] array = new string[100];
            string temp = "";
            string temp1 = "";
            
            //int counter = 1;
           // int num = 0;
            //Console.Clear();
            //int i = 0;

            for (int i=0; i<sentence.Length; i++)
            {
                for (int j=i; j<i+count+1; j++)
                {
                    temp1 += sentence[j];
                    if (sentence[j].Equals(" "))
                    {
                        temp += temp1;
                    }
                }
                                
                Console.WriteLine(temp);
                temp="";
                temp1="";
                i=i+count;

            }
           
           
           
           
            /*while (i <= sentence.Length){

                num=0;


                temp += sentence[i];

                if(count == counter){

                    if(sentence[i].Equals(" ")){
                        num = i;
                        array[i] = temp.Trim();
                        temp ="";
                        counter = 1;

                    }else{

                    

                    }

                }
                if(num!=0)
{
                    System.Console.WriteLine(array);
}
                i++;
            }*/


        }

        static void Main(string[] args)
        {

            WordBucket("hello im resting in my house", 10); //28

        }
    }
}