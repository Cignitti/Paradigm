using System;
Console.WindowWidth = 100;
Console.WriteLine(" _________________________________________________________");
Console.WriteLine("|   _____               _ _              ___   ___   ___  |");
Console.WriteLine("|  |  _  |___ ___ ___ _| |_|___ _____   |   | |_  | |_  | |");
Console.WriteLine("|  |   __| .'|  _| .'| . | | . |     |  | | |_  | |_|_  | |");
Console.WriteLine("|  |__|  |__,|_| |__,|___|_|_  |_|_|_|  |___|_| |_|_|___| |");
Console.WriteLine("|                          |___|                          |");
Console.WriteLine("|_________________________________________________________|");
Console.WriteLine("|----------------Creato da Edoardo Cignitti---------------|");
Console.WriteLine("|-----------------Versione 0.7.3(_110723)-----------------|");
Console.WriteLine("|_________________________________________________________|");
while (true)
{
    Console.WriteLine(" _____________________________________________");
    Console.WriteLine("|                                             |");
    Console.WriteLine("| 0.Uscire                                    |");
    Console.WriteLine("| 1.Matematica                                |");
    Console.WriteLine("| 2.Geometria                                 |");
    Console.WriteLine("| 3.Fisica                                    |");
    Console.WriteLine("|_____________________________________________|");
    Console.Write("|Inserire un'opzione: ");
    string insmateria = Console.ReadLine();
    switch (insmateria)
    {
        case "0":
            Environment.Exit(0);
            break;
        case "1":
            Console.WriteLine(" _____________________________________________");
            Console.WriteLine("|                                             |");
            Console.WriteLine("|1.Addizione                                  |");
            Console.WriteLine("|2.Sottrazione                                |");
            Console.WriteLine("|3.Moltiplicazione                            |");
            Console.WriteLine("|4.Divisione                                  |");
            Console.WriteLine("|5.Radice quadrata                            |");
            Console.WriteLine("|6.Logaritmo                                  |");
            Console.WriteLine("|7.Formula quadratica                         |");
            Console.WriteLine("|_____________________________________________|");
            Console.Write("|Inserire un'opzione: ");
            string insop = Console.ReadLine();
            switch (insop)
            {
                case "1":
                    Console.WriteLine(" _____________________________________________");
                    Console.WriteLine("|                                             |");
                    Console.Write("|Inserire a: ");
                    double num1add = Convert.ToDouble(Console.ReadLine());
                    Console.Write("|Inserire b: ");
                    double num2add = Convert.ToDouble(Console.ReadLine());
                    double risadd = (num1add + num2add);
                    Console.WriteLine("|Il risultato è " + risadd);
                    break;
                case "2":
                    Console.WriteLine(" _____________________________________________");
                    Console.WriteLine("|                                             |");
                    Console.Write("|Inserire a: ");
                    double num1sott = Convert.ToDouble(Console.ReadLine());
                    Console.Write("|Inserire b: ");
                    double num2sott = Convert.ToDouble(Console.ReadLine());
                    double rissott = (num1sott - num2sott);
                    Console.WriteLine("|Il risultato è " + rissott);
                    break;
                case "3":
                    Console.WriteLine(" _____________________________________________");
                    Console.WriteLine("|                                             |");
                    Console.Write("|Inserire a: ");
                    double num1x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("|Inserire b: ");
                    double num2x = Convert.ToDouble(Console.ReadLine());
                    double risx = (num1x * num2x);
                    Console.WriteLine("Il risultato è " + risx);
                    break;
                case "4":
                    Console.WriteLine(" _____________________________________________");
                    Console.WriteLine("|                                             |");
                    Console.Write("|Inserire a: ");
                    double num1div = Convert.ToDouble(Console.ReadLine());
                    Console.Write("|Inserire b: ");
                    double num2div = Convert.ToDouble(Console.ReadLine());
                    double risdiv = (num1div / num2div);
                    Console.WriteLine("Il risultato è " + risdiv);
                    break;
                case "5":
                    Console.WriteLine(" _____________________________________________");
                    Console.WriteLine("|                                             |");
                    Console.Write("|Inserire il numero: ");
                    double numsqrt = Convert.ToDouble(Console.ReadLine());
                    double sqrt = Math.Sqrt(numsqrt);
                    Console.WriteLine("|La radice quadrata di " + numsqrt + " è " + sqrt);
                    break;
                case "6":
                    Console.WriteLine(" _____________________________________________");
                    Console.WriteLine("|                                             |");
                    Console.Write("|Inserire il numero: ");
                    double numlog = Convert.ToDouble(Console.ReadLine());
                    double log = Math.Log(numlog);
                    Console.WriteLine("|Il logaritmo del numero " + numlog + " è " + log);
                    break;
                case "7":
                    Console.WriteLine(" _____________________________________________");
                    Console.WriteLine("|                                             |");
                    Console.Write("|Inserire coefficiente a: ");
                    double coeffa = Convert.ToDouble(Console.ReadLine());
                    Console.Write("|Inserire coefficiente b: ");
                    double coeffb = Convert.ToDouble(Console.ReadLine());
                    Console.Write("|Inserire coefficiente c: ");
                    double coeffc = Convert.ToDouble(Console.ReadLine());
                    double delta = coeffb * coeffb - 4 * coeffa * coeffc;
                    if (delta < 0)
                    {
                        Console.WriteLine("L'equazione è impossibile");
                    }
                    else if (delta == 0)
                    {
                        double X = -coeffb / (2 * coeffa);
                        Console.WriteLine("X= " + X);
                    }
                    else
                    {
                        double X1 = (-coeffb + Math.Sqrt(delta)) / (2 * coeffa);
                        double X2 = (-coeffb - Math.Sqrt(delta)) / (2 * coeffa);
                        Console.WriteLine("|X1= " + X1 + "\n|X2= " + X2);
                    }
                    break;
            }
            break;
        case "2":
            Console.WriteLine(" _____________________________________________");
            Console.WriteLine("|                                             |");
            Console.WriteLine("|1.Formule del quadrato                       | ");
            Console.WriteLine("|2.Formule del triangolo                      |");
            Console.WriteLine("|3.Formule del trapezio                       |");
            Console.WriteLine("|4.Formule del cerchio                        |");
            Console.Write("|Inserire un'opzione: ");
            string insop2 = Console.ReadLine();
            switch (insop2)
            {
                case "1":
                    {
                        Console.WriteLine(" _____________________________________________");
                        Console.WriteLine("|                                             |");
                        Console.WriteLine("|1.Perimetro                                  |");
                        Console.WriteLine("|2.Area                                       |");
                        Console.WriteLine("|3.Lato (radice dell'area)                    |");
                        Console.WriteLine("|4.Diagonale                                  |");
                        Console.WriteLine("|_____________________________________________|");
                        Console.Write("|Inserire un'opzione: ");
                        string insform1 = Console.ReadLine();
                        switch (insform1)
                        {
                            case "1":
                                Console.WriteLine(" _____________________________________________");
                                Console.WriteLine("|                                             |");
                                Console.Write("|Inserire misura lato (cm): ");
                                double lato = Convert.ToDouble(Console.ReadLine());
                                double P = (lato * 4);
                                Console.WriteLine("|Il perimetro del quadrato misura " + P + "cm");
                                break;
                            case "2":
                                Console.WriteLine(" _____________________________________________");
                                Console.WriteLine("|                                             |");
                                Console.Write("|Inserire misura lato (cm):");
                                double lato2 = Convert.ToDouble(Console.ReadLine());
                                double Area = Math.Pow(lato2, 2);
                                Console.WriteLine("|L'area del quadrato misura " + Area + "cm^2");
                                break;
                            case "3":
                                Console.WriteLine(" _____________________________________________");
                                Console.WriteLine("|                                             |");
                                Console.Write("|Inserire misura dell'area (cm^2): ");
                                double Area2 = Convert.ToDouble(Console.ReadLine());
                                double lato3 = Math.Sqrt(Area2);
                                Console.WriteLine("|Il lato del quadrato misura " + lato3 + "cm");
                                break;
                            case "4":
                                Console.WriteLine(" _____________________________________________");
                                Console.WriteLine("|                                             |");
                                Console.Write("|Inserire misura del lato (cm): ");
                                double lato4 = Convert.ToDouble(Console.ReadLine());
                                double diag = (lato4 * Math.Sqrt(2));
                                Console.WriteLine("|La diagonale del quadrato misura " + diag + "cm");
                                break;
                        }
                        break;
                    }
                case "2":
                    Console.WriteLine(" _____________________________________________");
                    Console.WriteLine("|                                             |");
                    Console.WriteLine("|1.Perimetro                                  |");
                    Console.WriteLine("|2.Area                                       |");
                    Console.WriteLine("|3.Base                                       |");
                    Console.WriteLine("|4.Altezza                                    |");
                    Console.WriteLine("|_____________________________________________|");
                    Console.Write("Inserire un'opzione: ");
                    string insform2 = Console.ReadLine();
                    switch (insform2)
                    {
                        case "1":
                            Console.WriteLine(" _____________________________________________");
                            Console.WriteLine("|                                             |");
                            Console.Write("|Inserire L1: ");
                            double latotr = Convert.ToDouble(Console.ReadLine());
                            Console.Write("|Inserire L2: ");
                            double latotr2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("|Inserire L3: ");
                            double latotr3 = Convert.ToDouble(Console.ReadLine());
                            double PTr = (latotr + latotr2 + latotr3);
                            Console.WriteLine("|Il perimetro del triangolo è: " + PTr);
                            break;
                        case "2":
                            Console.WriteLine(" _____________________________________________");
                            Console.WriteLine("|                                             |");
                            Console.Write("|Inserire base: ");
                            double BTr = Convert.ToDouble(Console.ReadLine());
                            Console.Write("|Inserire altezza: ");
                            double HTr = Convert.ToDouble(Console.ReadLine());
                            double ATr = (BTr * HTr) / 2;
                            Console.WriteLine("|L'area del triangolo è: " + ATr);
                            break;
                        case "3":
                            Console.WriteLine(" _____________________________________________");
                            Console.WriteLine("|                                             |");
                            Console.Write("|Inserire area: ");
                            double ATr2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("|Inserire altezza: ");
                            double HTr2 = Convert.ToDouble(Console.ReadLine());
                            double BTr2 = (ATr2 * 2) / HTr2;
                            Console.WriteLine("|La base del triangolo è: " + BTr2);
                            break;
                        case "4":
                            Console.WriteLine(" _____________________________________________");
                            Console.WriteLine("|                                             |");
                            Console.Write("|Inserire area: ");
                            double ATr3 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("|Inserire base: ");
                            double BTr3 = Convert.ToDouble(Console.ReadLine());
                            double HTr3 = (ATr3 * 2) / BTr3;
                            Console.WriteLine("|L'altezza del triangolo è: " + HTr3);
                            break;

                    }
                    break;
                case "3":
                    Console.WriteLine(" _____________________________________________");
                    Console.WriteLine("|                                             |");
                    Console.WriteLine("|1.Area                                       |");
                    Console.WriteLine("|2.Perimetro                                  |");
                    Console.WriteLine("|3.Altezza                                    |");
                    Console.Write("|Inserire un'opzione: ");
                    string insform = Console.ReadLine();
                    switch (insform)
                    {
                        case "1":
                            Console.WriteLine(" _____________________________________________");
                            Console.WriteLine("|                                             |");
                            Console.Write("|Inserire misura base maggiore: ");
                            double BTrap = Convert.ToDouble(Console.ReadLine());
                            Console.Write("|Inserire misura base minore: ");
                            double btrap = Convert.ToDouble(Console.ReadLine());
                            Console.Write("|Inserire misura altezza: ");
                            double htrap = Convert.ToDouble(Console.ReadLine());
                            double ATrap = ((BTrap + btrap) * htrap) / 2;
                            Console.WriteLine("L'area del trapezio è: " + ATrap);
                            break;
                        case "2":
                            Console.WriteLine(" _____________________________________________");
                            Console.WriteLine("|                                             |");
                            Console.Write("|Inserire misura base maggiore: ");
                            double BTrap2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("|Inserire misura base minore: ");
                            double btrap2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("|Inserire misura L1: ");
                            double L1Trap = Convert.ToDouble(Console.ReadLine());
                            Console.Write("|Inserire misura L1: ");
                            double L2Trap = Convert.ToDouble(Console.ReadLine());
                            double PTrap = (BTrap2 + btrap2 + L1Trap + L2Trap);
                            Console.WriteLine("|Il perimetro del trapezio è: " + PTrap);
                            break;
                        case "3":
                            Console.WriteLine(" _____________________________________________");
                            Console.WriteLine("|                                             |");
                            Console.Write("|Inserire misura area trapezio: ");
                            double ATrap2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("|Inserire misura base maggiore: ");
                            double BTrap3 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("|Inserire misura base minore: ");
                            double btrap3 = Convert.ToDouble(Console.ReadLine());
                            double htrap2 = (2 * ATrap2) / (BTrap3 + btrap3);
                            Console.Write("|L'altezza del trapezio è: " + htrap2);
                            break;
                    }
                    break;
            }
            break;
        case "3":
            Console.WriteLine(" _____________________________________________");
            Console.WriteLine("|                                             |");
            Console.WriteLine("|1.Calcolo della velocità                     |");
            Console.WriteLine("|2.Calcolo del tempo                          |");
            Console.WriteLine("|3.Conversione m/s -> Mach                    |");
            Console.WriteLine("|4.Conversione m/s -> Km/h                    |");
            Console.WriteLine("|_____________________________________________|");
            Console.Write("|Inserire un'opzione: ");
            string insop3 = Console.ReadLine();
            switch (insop3)
            {
                case "1":
                    //Moto rettilineo uniforme
                    Console.WriteLine(" _____________________________________________");
                    Console.WriteLine("|                                             |");
                    Console.Write("|Inserire distanza(m): ");
                    double dist = Convert.ToDouble(Console.ReadLine());
                    Console.Write("|Inserire tempo(s): ");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    double vel = (dist / temp);
                    Console.WriteLine("|->" + vel + "m/s");
                    break;
                case "2":
                    Console.WriteLine(" _____________________________________________");
                    Console.WriteLine("|                                             |");
                    Console.Write("|Inserire distanza(m): ");
                    double dist2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("|Inserire velocità(m/s): ");
                    double vel2 = Convert.ToDouble(Console.ReadLine());
                    double temp2 = (dist2 / vel2);
                    Console.Write("|->" + temp2 + "s");
                    break;
                case "3":
                    Console.WriteLine(" _____________________________________________");
                    Console.WriteLine("|                                             |");
                    Console.Write("|Inserire velocità(m/s): ");
                    double vel3 = Convert.ToDouble(Console.ReadLine());
                    double Mach = (vel3 * 0.002939);
                    Console.Write("|-> Mach" + Mach);
                    break;
                case "4":
                    Console.Write("|Inserire velocità (m/s): ");
                    double vel4 = Convert.ToDouble(Console.ReadLine());
                    double kmh = (vel4) * 3.6;
                    Console.WriteLine(vel4 + " |m/s" + " = " + kmh + " km/h");
                    break;
            }
            break;
    }
    Console.ReadKey();
}