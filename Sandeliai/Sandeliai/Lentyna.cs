using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandeliai
{
  
  public partial class Lentyna : Form
  {
    IPaketas Paketas;
    List<IPaketas> paketai;
    Paketas P;

    public Lentyna(ILentyna lentyna)
    {
      InitializeComponent();
      paketai = lentyna.paketai;
      
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      SpausdintiViska();
      SpausdintiPaketa(((ListBox)sender).SelectedIndex);
    }

    IPaketas NuskaitytiPaketa(int index)
    {
      List<IPaketas> Paketai = new List<IPaketas>();

      return Paketai[index];
    }

    void SpausdintiPaketa(int index)
    {
      Paketas = NuskaitytiPaketa(index);

      string Info = String.Format("Ilgis: {0, -5} /n Plotis: {1, -5} \n Aukstis {2, -5} \n",
        Paketas.Ilgis, Paketas.Plotis, Paketas.Aukstis +
        "Svoris: {0, -5} \n Verte: {1, -7} \n Aprasymas: {2} \n ID: {3}",
        Paketas.Svoris, Paketas.Verte, Paketas.Aprasymas, Paketas.ID);

        textBox1.AppendText(Info);
    }

    void SpausdintiViska ()
    {
      foreach (var paketas in paketai)
      {
        listBox1.Text = paketas.ID + "\n";
      }
    }
  }
}
