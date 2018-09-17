using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandeliai
{
  class LinasDummys : ISandelys
  {
    public LinasDummys()
    {

    }

    public string path()
    {
      return "base path";
    }

    public List<ILentyna> lentynos => throw new NotImplementedException();

    public string pavadinimas => throw new NotImplementedException();

    public string adresas => throw new NotImplementedException();

    string ISandelys.path => throw new NotImplementedException();

    public double verte()
    {
      throw new NotImplementedException();
    }

    public static List<ISandelys> getDummies()
    {

    }
  }
}
