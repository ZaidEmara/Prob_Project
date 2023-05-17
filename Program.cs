namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double Q1 = 0; 
            double Q3 = 0;
            Console.WriteLine("Please Enter number of elements in the data set:");
            int num_elements = int.Parse(Console.ReadLine());
            double[] elements = new double[num_elements];
            Console.WriteLine("Please Enter your data set:");
            for (int i = 0; i < num_elements; i++)
            {
                elements[i] = double.Parse(Console.ReadLine());
            }
            //caculating Median:
            Console.WriteLine("----------------------------------------------------");
            Array.Sort(elements);
            if (num_elements % 2 != 0)
            {
                int n = (num_elements / 2);
                Console.WriteLine("The Median is:" + elements[n]);

            }
            else
            {
            Console.WriteLine("The Median is:" +(elements[((num_elements - 1) / 2)] + elements[((num_elements-1) / 2) + 1])/2);
            }



            //calculating the range:
            double max, min;
            max = elements[0];
            min = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
                if (elements[i] < min)
                {
                    min = elements[i];
                }

            }
            double range = (max - min);
            Console.WriteLine("The Range is:" + range);

            //calculating first Quartile:
            double indexofQ1 =((0.25*num_elements)-1) ;

            int ceiledindexofQ1 = (int) Math.Ceiling(indexofQ1);
            if(indexofQ1 == ceiledindexofQ1)
            {
                Q1= (elements[(int)indexofQ1] + elements[(int)indexofQ1 + 1 ])/2;
                Console.WriteLine("the first quartile is:" + Q1);

            }
            else
            {
                Q1 = elements[ceiledindexofQ1];
                Console.WriteLine("the first quartile is:" + Q1);
            }
               

            

            //calculating third Quartile:
            double indexofQ3 = ((0.75 * num_elements) - 1);

            int ceiledindexofQ3 = (int)Math.Ceiling(indexofQ3);
            if (indexofQ3 == ceiledindexofQ3)
            {
               Q3= (elements[(int)indexofQ3] + elements[(int)indexofQ3 + 1]) / 2;
                Console.WriteLine("the third quartile is:" + Q3);

            }
            else
            {
                Q3 = elements[ceiledindexofQ3];
                Console.WriteLine("the third quartile is:" + Q3);
            }


            //calculating the P90 of the values:
            double indexofP90 = ((0.90 * num_elements) - 1);

            int ceiledindexofP90 = (int)Math.Ceiling(indexofP90);
            if (indexofP90 == ceiledindexofP90)
            {
                Console.WriteLine("the P90 of the values:" + (elements[(int)indexofP90] + elements[(int)indexofP90 + 1]) / 2);

            }
            else
                Console.WriteLine("the P90 of the values:" + elements[ceiledindexofP90]);





            // calculating the IQR :
            double IQR = (Q3 - Q1);
            Console.WriteLine("the Interquartile is:"+IQR);
            //calculating the outlier enterval:
            double lower = (Q1 - 1.5 * IQR);
            double upper = (Q3 + 1.5 * IQR);
            Console.WriteLine("the boundaries of the outlier region is:[{0},{1}]",lower,upper);









            //checking if there is any outlier value:
            for (int i = 0; i < num_elements; i++)
            {
                if (elements[i] < lower)
                {
                    Console.WriteLine(elements[i]+"is an outlier");
                }
                
            }

            for (int i = 0; i < num_elements; i++)
            {
                if (elements[i] > upper)
                {
                    Console.WriteLine(elements[i] + " is an outlier");
                }

            }




        }
    }
}