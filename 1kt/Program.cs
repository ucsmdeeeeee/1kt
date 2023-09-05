calck sss = new calck();
sss.SUM(1, 2, 3);
Console.WriteLine();

plantsvszombies pvz0 = new plantsvszombies();
plantsvszombies pvz1 = new plantsvszombies(rost: 1.1, ves: 2.2);
plantsvszombies pvz2 = new plantsvszombies(rost: 1, ves: 2, shirina: 3.3);
pvz0.write();
Console.WriteLine();
pvz1.write();
Console.WriteLine();
pvz2.write();
Console.WriteLine();

Mass510 arr = new Mass510(5);
arr[0] = 1;
arr[1.123] = 2;
arr[1.89] = 3;
arr[3.01] = 4;
arr[4.222] = 5;
Console.WriteLine("mass:");
for (int i = 0; i < arr.length; i++)
    Console.Write("{0}\t", arr[i]);
Console.ReadLine();

class calck
{
    public void SUM(int a, int b)
    {
        int res = a + b;
        Console.WriteLine(res);
    }
    public void SUM(int a, int b, int c)
    {
        int res = a + b + c;
        Console.WriteLine(res);
    }
    public int SUM(int a, int b, int c, int d)
    {
        int res = a + b + c + d;
        Console.WriteLine(res);
        return res;
    }
    public void SUM(double a, double b)
    {
        double res = a + b;
        Console.WriteLine(res);
    }
    public void SUM(double a, double b, double c)
    {
        double res = a + b + c;
        Console.WriteLine(res);
    }
    public double SUM(double a, double b, double c, double d)
    {
        double res = a + b + c + d;
        Console.WriteLine(res);
        return res;
    }
}


class plantsvszombies
{
    public double rost, ves, shirina;
    public plantsvszombies() { }
    public plantsvszombies(double rost, double ves)
    {
        this.rost = rost;
        this.ves = ves;
    }
    public plantsvszombies(double rost, double ves, double shirina)
    {
        this.rost = rost;
        this.ves = ves;
        this.shirina = shirina;

    }
    public void write()
    {
        Console.Write($"{rost}, {ves}, {shirina}");
    }

}
class Mass510
{
    int[] arr;
    public int length;

    public Mass510(int Size)
    {
        arr = new int[Size];
        length = Size;
    }
    public int this[double index]
    {
        get
        {
            return arr[(int)Math.Round(index)];
        }
        set
        {
            arr[(int)Math.Round(index)] = value + 5;
        }
    }
}