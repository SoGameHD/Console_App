// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine(CultureInfo.InstalledUICulture);

void BonjourAuRevoir()
{
    DateTime midi = new DateTime(2022, 1, 1, 12, 0, 0);
    DateTime soir = new DateTime(2022, 1, 1, 19, 0, 0);
    DateTime matin = new DateTime(2022, 1, 1, 6, 0, 0);
    DateTime nuit = new DateTime(2022, 1, 1, 0, 0, 0);

    if (DateTime.Now.TimeOfDay >= matin.TimeOfDay && DateTime.Now.TimeOfDay < midi.TimeOfDay)
    {
        Console.WriteLine("Bonne matinée !");
    }
    else if (DateTime.Now.TimeOfDay >= midi.TimeOfDay && DateTime.Now.TimeOfDay < soir.TimeOfDay)
    {
        Console.WriteLine("Bonne après-midi !");
    }
    else if (DateTime.Now.TimeOfDay >= soir.TimeOfDay && DateTime.Now.TimeOfDay < nuit.TimeOfDay)
    {
        Console.WriteLine("Bonne soirée !");
    }
    else if (DateTime.Now.TimeOfDay >= nuit.TimeOfDay && DateTime.Now.TimeOfDay < matin.TimeOfDay)
    {
        Console.WriteLine("Bonne nuit !");
    }
}

BonjourAuRevoir();

Console.WriteLine("Ecriver un texte : ");
string entree = Console.ReadLine();
string miroir = "";
for (int i = (entree.Length - 1); i >= 0; i--)
{
    miroir += entree[i];
}
Console.WriteLine("Vous avez entre le texte suivant : " + miroir);


string revs = "";
for (int i = entree.Length - 1; i >= 0; i--) //String Reverse
{
    //Console.WriteLine(i);
    revs += entree[i].ToString();
}
if (revs == entree) 
{
    Console.WriteLine("Bien dit");
}

Console.ReadKey();

BonjourAuRevoir();
