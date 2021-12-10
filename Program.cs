using System;

namespace GroupX
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Make it Divisible by 25");
            Console.WriteLine("2. Pizza Force");
            Console.WriteLine("3. Watermelon");
            Console.WriteLine("4. Pineapple");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1: 
                    Divisible();
                    break;
                case 2:
                    PizzaForces();
                    break;
                case 3:
                    Watermelon();
                    break;
                case 4:
                    Pineapple();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        private static void Pineapple()
        {
            Console.WriteLine("Pineapple!");
        }

        public static void Divisible() 
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int t=0; t<T; t++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                int ans=Int32.MaxValue;
                for (int i=0; i<line.Length; i++) 
                {
                    for (int j=i+1; j<line.Length; j++)
                    {
                        if (line[i]=='0' && line[j]=='0') ans=line.Length-2-i;
                        if (line[i]=='2' && line[j]=='5') ans=line.Length-2-i;
                        if (line[i]=='5' && line[j]=='0') ans=line.Length-2-i;
                        if (line[i]=='7' && line[j]=='5') ans=line.Length-2-i;
                    }
                }
                Console.WriteLine(ans);
            }  
        }
        
        
        public static void PizzaForces() 
        {
            int T=Convert.ToInt32(Console.ReadLine());
            for (int t=0; t<T; t++)
            {
                int W=Console.Read(), H=Console.Read();
                int x1=Console.Read(), y1=Console.Read(),
                        x2=Console.Read(), y2=Console.Read();
                int w2=Console.Read(), h2=Console.Read();
                int w1=x2-x1, h1=y2-y1;
                
                int ans = Int32.MaxValue;

                if (w2+w1<=W)
                {
                    int nx1=w2;
                    ans=Math.Min(ans, nx1-x1);

                    int nx2=W-w2;
                    ans=Math.Min(ans, x2-nx2);
                }
                if (h2+h1<=H)
                {
                    int ny1=h2;
                    ans=Math.Min(ans, ny1-y1);

                    int ny2=H-h2;
                    ans=Math.Min(ans, y2-ny2);
                }
                ans=Math.Max(ans, 0);
                
                Console.WriteLine(ans==Int32.MaxValue?-1:ans);
            }
        }

        public static void Watermelon()
        {
            Console.WriteLine("Enter a number: ");
            int w=Convert.ToInt32(Console.ReadLine());
            if(w%2==0&&w>2){
                Console.WriteLine("YES");
            }
            else{
                Console.WriteLine("NO");
            }
        }
    }
}
