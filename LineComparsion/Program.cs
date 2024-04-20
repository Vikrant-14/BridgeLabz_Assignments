using System;

class LineComparison{

    int x1,x2;
    int y1,y2;

    LineComparison()
    {
        x1 = x2 = 0;
        y1 = y2 = 0;
    }

    public void AcceptRecord()
    {
        Console.Write("Enter X1 co-ordinates : ");
        this.x1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Y1 co-ordinates : ");
        this.y1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter X2 co-ordinates : ");
        this.x2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Y2 co-ordinates : ");
        this.y2 = Convert.ToInt32(Console.ReadLine());
    }

    public double LengthCalculator()
    {
        return Math.Sqrt(Math.Pow((this.x2 - this.x1),2) + Math.Pow((this.y2 - this.y1),2));
    }

    public static bool LineEquality(double line1, double line2)
    {
        return line1.Equals(line2);       
    }

    public static void LineCompare(double line1, double line2)
    {
        int com = line1.CompareTo(line2);

        if(com == -1)
        {
            Console.WriteLine("Line1 is smaller than line2");
        }
        else if(com == 1)
        {
            Console.WriteLine("Line1 is greater than line2");
        }
        else
        {
            Console.WriteLine("Line1 and line2 are equal");
        }
    }

    public void Display()
    {
        //Console.WriteLine("Welcome to Line Comparison Computation Program!!!");
        Console.WriteLine("X1 co-ordinates : " + this.x1);
        Console.WriteLine("Y1 co-ordinates : " + this.y1);
        Console.WriteLine("X2 co-ordinates : " + this.x2);
        Console.WriteLine("Y2 co-ordinates : " + this.y2);
    }
    static void Main()
    {
        LineComparison l1 = new LineComparison();
        LineComparison l2 = new LineComparison();

        l1.AcceptRecord();
        Console.WriteLine("----------------------------");
        l2.AcceptRecord();
        Console.WriteLine("----------------------------");

        double line1 = l1.LengthCalculator();
        double line2 = l2.LengthCalculator();
        
        Console.WriteLine("Comparsion\n");
        LineCompare(line1, line2);

    }
}
