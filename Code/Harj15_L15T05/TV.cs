using System;

[Serializable]
struct TV
{
    public TV (string ohjelmaNimi, string kanava, string aloitus, string lopetus, string info)
    {
        Ohjelmanimi = ohjelmaNimi;
        Kanava = kanava;
        Aloitusaika = aloitus;
        Lopetusaika = lopetus;
        Ohjelmainfo = info;
    }
    public override string ToString()
    {
        return "- " +  Ohjelmanimi + ", kanavalla " + Kanava + " alkaa kello " + Aloitusaika + " ja päättyy kello " + Lopetusaika + ". " + Ohjelmainfo;
    }
    public string Ohjelmanimi;
    public string Kanava;
    public string Aloitusaika;
    public string Lopetusaika;
    public string Ohjelmainfo;
}
