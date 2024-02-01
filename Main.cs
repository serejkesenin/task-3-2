using System;
class Program
{
    static void Main()
    {
        Massive[] mass = new Massive[3];
        Massive odn_mass = new Odnomerniy();
        Massive dvum_mass = new Dvumerniy();
        Massive stup_mass = new Stupenchatiy();
        mass[0] = odn_mass;
        mass[1] = dvum_mass;
        mass[2] = stup_mass;
        for (int i = 0; i < 3; i++)
        {
            mass[i].GetMass();
            mass[i].PrintMass();
            mass[i].Average();
        }
    }
}