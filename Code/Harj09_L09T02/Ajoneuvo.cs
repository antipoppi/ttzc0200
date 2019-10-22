using System;

struct Ajoneuvo
{
    public override string ToString()
    {
        return Valmistaja + " " + Merkki + ", vm." + Vuosimalli + ", " + Hinta + " euroa";
    }
    public string Valmistaja;
    public string Merkki;
    public int Vuosimalli;
    public int Hinta;
}