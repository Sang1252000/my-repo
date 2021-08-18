using System;

namespace HandsOnConstructors
{
    class Sample
    {
        int a;
        int b;
        public Sample()//default constructor
        {
            a = 10;
            b = 20;
        }
        public Sample(int a, int b)//parameterized constructor
        {
            this.a = a;
            this.b = b;
        }
        public Sample(Sample sample)//copy constructor
        {
            this.a = sample.a;
            this.b = sample.b;
        }
        public void show()
        {
            Console.WriteLine("a :{0} b: {1}", a, b);
        }

}
    class Program
    {
        static void Main(string[] args)
        {

            Sample s = new Sample();
            s.show();
            Sample s1 = new Sample(12,23);
            s1.show();
            Sample s2 = new Sample(s1);
            s2.show();
            Sample s3 = new Sample(s);
            s3.show();


        }
    }
}
