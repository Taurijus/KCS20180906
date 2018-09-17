namespace Sandeliai
{
  public interface IPaketas
  {
    double Ilgis { get; }
    double Plotis { get; }
    double Aukstis { get; }
    double Svoris { get; }
    double Verte { get; }
    string Aprasymas { get; }
    string ID { get; }
  }
}