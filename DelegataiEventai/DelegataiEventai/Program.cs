using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegataiEventai
{
  public delegate int MFunction(int a, int b);

  class Program
  {
    MFunction operacija;
    int pirmas;
    static void Main(string[] args)
    {
      var a = new Point();
      a.onChange += onPointChanged;
      a.X = 9;
      a.Y = 6;
      var d = a.DoMathWithPoint(Distance);
      var t = a.DoMathWithPoint((x, y) => x + y);
    }

    public void plus(int pirmas)
    {
      this.pirmas = pirmas;
      // saugom +
      operacija = (x, y) => x + y;
    }

    public void minus(int pirmas)
    {
      this.pirmas = pirmas;
      // saugom -
      operacija = (x, y) => x - y;
    }


    public double lygu(int antras)
    {
      // switch case + case -
      return operacija(pirmas, antras);
    }

    private static int Distance(int x, int y)
    {
      return (int)Math.Sqrt(x * x + y * y);
    }

    private static void onPointChanged(Point obj)
    {
      Console.WriteLine(obj.ToString());
    }
  }

  class Point
  {
    int x, y;
    public event Action<Point> onChange;

    public int X
    {
      get { return x; }
      set
      {
        x = value;
        OnChange();
      }
    }

    public int Y
    {
      get { return y; }
      set
      {
        y = value;
        OnChange();
      }
    }
    void OnChange()
    {
      onChange?.Invoke(this);
    }

    public int DoMathWithPoint(MFunction g)
    {
      return g(X, Y);
    }

    public override string ToString()
    {
      return x + " " + y;
    }
  }
}
