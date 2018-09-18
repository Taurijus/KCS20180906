using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sandeliai
{
  class Paketas : IPaketas
  {
    public double Ilgis { get; private set; }
    public double Plotis { get; private set; }
    public double Aukstis { get; private set; }
    public double Svoris { get; private set; }
    public double Verte { get; private set; }
    public string Aprasymas { get; private set; }
    public string ID { get; private set; }

    ILentyna lentyna;

    public Paketas(string path)
    {
      SkaitytiPaketus(path);
    }

    public Paketas (string path, double ilgis, double plotis, double aukstis,
      double svoris, double verte, string aprasymas, string id)
    {
      SukurtiPaketa(path, ilgis, plotis, aukstis, svoris, verte, aprasymas, id);
    }

    // Duomenys kiekvienoj eilutej kitas duomuo
    void SkaitytiPaketus(string path)
    {
      using (StreamReader reader = new StreamReader(path))
      {
        Ilgis = double.Parse(reader.ReadLine());
        Plotis = double.Parse(reader.ReadLine());
        Aukstis = double.Parse(reader.ReadLine());
        Svoris = double.Parse(reader.ReadLine());
        Verte = double.Parse(reader.ReadLine());
        Aprasymas = reader.ReadLine();
        ID = reader.ReadLine();
      }
    }

    public void IstrintiPaketa (string path)
    {
      File.Delete(path);
    }

    void SukurtiPaketa (string path, double ilgis, double plotis, double aukstis,
      double svoris, double verte, string aprasymas, string id)
    {
      File.Create(path);

      using (StreamWriter writer = new StreamWriter(path))
      {
        writer.WriteLine("Ilgis: {0, -5} /n Plotis: {1, -5} \n Aukstis: {2, -5} \n",
        ilgis, plotis, aukstis +
        "Svoris: {0, -5} \n Verte: {1, -7} \n Aprasymas: {2} \n ID: {3}",
        svoris, verte, aprasymas, id);

        Ilgis = ilgis;
        Plotis = plotis;
        Aukstis = aukstis;
        Svoris = svoris;
        Verte = verte;
        Aprasymas = aprasymas;
        ID = id;
      }
    }
  }
}
