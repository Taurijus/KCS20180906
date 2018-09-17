using System.Collections.Generic;

namespace Sandeliai
{
  public interface ILentyna
  {
    string path { get; }
    List<IPaketas> paketai { get; }
    string pavadinimas { get; }
    double verte();
  }
}