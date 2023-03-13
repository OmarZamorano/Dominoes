class Domino
{
    private int l1;
    private int l2;
    int total;
    public Domino (int l1, int l2)
    {
        this.l1=l1;
        this.l2=l2;
    }

    public void Imprime ()
    {
        Console.WriteLine((l1+l2));
    }

    public static Domino operator + (Domino d1,Domino d2)
    {
        int l1= d1.l1 + d1.l2;
        int l2=d2.l1 + d2.l2;
        return new Domino(l1,l2);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Domino d1 = new Domino (0,1);
        Domino d2 = new Domino (2,3);
        Domino total= d1 + d2;
        total.Imprime();
    }
}