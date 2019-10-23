using System;

struct Vehicle
{
    public string Name;
    public int ModelYear;
    public int Efficiency;
    public override string ToString()
    {
        return "Name: " + Name + ". Model year: " + ModelYear + ". Efficiency: " + Efficiency + ".";
    }
}