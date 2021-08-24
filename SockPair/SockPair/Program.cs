using System;

namespace SockPair
{



    class Program
    {
        public static void SockCount(string sock)
        {
            string[] temp = new String[sock.Length];         
         
            for (int i = 0;  i< sock.Length; i++)
            {
                temp[i] = Convert.ToString( sock[i]);    
            }
            Array.Sort(temp);
            int count = 0;
            int result=0;
            int final = 0;
            for (int i = 0; i < sock.Length; i++)
            {

                if (i < sock.Length-1)
                {
                    if (temp[i] != temp[i + 1])
                    {
                        count += 1;
                        if (count % 2 == 0)
                        {
                            result = count / 2;
                        }
                        else
                        {
                            result = Convert.ToInt32(count / 2);
                            Console.WriteLine(result);
                        }
                        final += result;
                        count = 0;
                    }
                    else
                    {
                        count += 1;
                    }
                }
                else
                {
                    count += 1;
                    if (count % 2 == 0)
                    {
                        result = count / 2;
                    }
                    else
                    {
                        result =  + Convert.ToInt32(count / 2);

                    }
                    final += result;
                    count = 0;

                }
            }




            Console.WriteLine(final);
            Console.ReadLine();
                
            
            


        }

        static void Main(string[] args)
        {

            string sock = "AA";
            SockCount(sock);
            sock = "ABABC";
            SockCount(sock);
            sock = "CABBACCC";
            SockCount(sock);
            Console.WriteLine("Hello World!");
        }
    }
}
