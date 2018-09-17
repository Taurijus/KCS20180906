using System.Collections.Generic;

namespace Sandeliai
{
  public interface ILentyna
  {
    List<IPaketas> paketai { get; }
    string pavadinimas { get; }
    double verte();
  }
}