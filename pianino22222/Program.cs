namespace pianino22222
{
       internal class Program
       {

            static void Main(string[] args)
            {
                Console.WriteLine("Привет. Выбери октаву: 5- F1, 6-F2, 7-F3, 8-F4. Для переключения между октавами нажми L, закрыть программу- Z");
                do
                {
                    ConsoleKeyInfo octava = Console.ReadKey();
                    if (octava.Key == ConsoleKey.Z)
                    {
                        Console.WriteLine("Пока((");
                        break;
                    }
                    else if (octava.Key == ConsoleKey.F1)
                    {
                        double[] octave = OctaveFirst();
                        ynikal(octave);
                    }
                    else if (octava.Key == ConsoleKey.F2)
                    {
                        int[] octave = OctaveSekond();
                        zvyki(octave);

                    }
                    else if (octava.Key == ConsoleKey.F3)
                    {
                        int[] octave = Octavetretia();
                        zvyki(octave);

                    }
                    else if (octava.Key == ConsoleKey.F4)
                    {
                        int[] octave = Octavechetvertaz();
                        zvyki(octave);

                    }
                } while (true);
            }
            static void zvyki(int[] Octave)
            {
                while (true)
                {

                    ConsoleKeyInfo zvyk = Console.ReadKey();
                    if (zvyk.Key == ConsoleKey.L)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Выбери актаву еще раз");
                        break;
                    }
                    else if (zvyk.Key == ConsoleKey.Z)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Пока(((");
                        Environment.Exit(0);
                    }
                    else
                    {
                        switch (zvyk.Key)
                        {

                            case ConsoleKey.A:
                                int A = Octave[0];
                                Console.Beep(A, 500);
                                break;
                            case ConsoleKey.Q:
                                int q = Octave[1];
                                Console.Beep(q, 500);
                                break;
                            case ConsoleKey.S:
                                int s = Octave[2];
                                Console.Beep(s, 500);
                                break;
                            case ConsoleKey.W:
                                int w = Octave[3];
                                Console.Beep(w, 500);
                                break;
                            case ConsoleKey.D:
                                int d = Octave[4];
                                Console.Beep(d, 500);
                                break;
                            case ConsoleKey.E:
                                int e = Octave[5];
                                Console.Beep(e, 500);
                                break;
                            case ConsoleKey.F:
                                int f = Octave[6];
                                Console.Beep(f, 500);
                                break;
                            case ConsoleKey.R:
                                int r = Octave[7];
                                Console.Beep(r, 500);
                                break;
                            case ConsoleKey.G:
                                int g = Octave[8];
                                Console.Beep(g, 500);
                                break;
                            case ConsoleKey.H:
                                int h = Octave[9];
                                Console.Beep(h, 500);
                                break;
                            case ConsoleKey.T:
                                int t = Octave[10];
                                Console.Beep(t, 500);
                                break;
                            case ConsoleKey.J:
                                int j = Octave[11];
                                Console.Beep(j, 500);
                                break;


                        }

                    }
                }

            }
            static double[] klavisha1()
            {
                double[] octave = new double[] { 523.3, 554.4, 587.3, 622.3, 659.3, 698.5, 740.0, 784.0, 830.6, 880.0, 932.3, 987.8 };
                return octave;
            }
            static int[] klavisha2()
            {
                int[] octave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                return octave;
            }
            static int[] klavisha3()
            {
                int[] octave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                return octave;
            }
            static int[] klavisha4()
            {
                int[] octave = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
                return octave;
            }
            static double[] OctaveFirst()
            {
                Console.WriteLine("Октава 5");
                double[] octave = klavisha1();
                return octave;
            }
            static int[] OctaveSekond()
            {
                Console.WriteLine("Октава 6");
                int[] octave = klavisha2();
                return octave;
            }
            static int[] Octavetretia()
            {
                Console.WriteLine("Октава 7");
                int[] octave = klavisha3();
                return octave;
            }
            static int[] Octavechetvertaz()
            {
                Console.WriteLine("Октава 8");
                int[] octave = klavisha4();
                return octave;
            }
            static void ynikal(double[] Octave)
            {
                while (true)
                {

                    ConsoleKeyInfo zvykynikal = Console.ReadKey();
                    if (zvykynikal.Key == ConsoleKey.L)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Выбери актаву еще раз");
                        break;
                    }
                    else if (zvykynikal.Key == ConsoleKey.Z)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Пока((");
                        Environment.Exit(0);
                    }
                    else
                    {
                        switch (zvykynikal.Key)
                        {

                            case ConsoleKey.A:
                                double a = Octave[0];
                                Console.Beep((int)a, 500);
                                break;
                            case ConsoleKey.Q:
                                double q = Octave[1];
                                Console.Beep((int)q, 500);
                                break;
                            case ConsoleKey.S:
                                double s = Octave[2];
                                Console.Beep((int)s, 500);
                                break;
                            case ConsoleKey.W:
                                double w = Octave[3];
                                Console.Beep((int)w, 500);
                                break;
                            case ConsoleKey.D:
                                double d = Octave[4];
                                Console.Beep((int)d, 500);
                                break;
                            case ConsoleKey.E:
                                double e = Octave[5];
                                Console.Beep((int)e, 500);
                                break;
                            case ConsoleKey.F:
                                double f = Octave[6];
                                Console.Beep((int)f, 500);
                                break;
                            case ConsoleKey.R:
                                double r = Octave[7];
                                Console.Beep((int)r, 500);
                                break;
                            case ConsoleKey.G:
                                double g = Octave[8];
                                Console.Beep((int)g, 500);
                                break;
                            case ConsoleKey.H:
                                double h = Octave[9];
                                Console.Beep((int)h, 500);
                                break;
                            case ConsoleKey.T:
                                double t = Octave[10];
                                Console.Beep((int)t, 500);
                                break;
                            case ConsoleKey.J:
                                double j = Octave[11];
                                Console.Beep((int)j, 500);
                                break;
                        }
                    }
                }
            }
        }
    }