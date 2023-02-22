using v23;

Console.WriteLine("Luas Persegi panjang");
Console.Write("Masukan p: "); 
double p = Convert.ToDouble(Console.ReadLine());
Console.Write("Masukan l : ");
double l = Convert.ToDouble(Console.ReadLine());

Rumus rumus = new Rumus();
Console.Write($"luas persegi panjang dengan p :{p} dan l : {l} adalah ");
Console.WriteLine(rumus.persegipanjang (p,l));