using System.Collections.Generic;

namespace Sandeliai
{
  public interface ISandelys
  {
    string path { get; }
    List<ILentyna> lentynos { get; }
    string pavadinimas { get; }
    string adresas { get; }
    double verte();
  }
}