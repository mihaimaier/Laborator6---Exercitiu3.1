using System;

namespace Laborator6___Exercitiu3._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti Numarul de Elevi in Catalog");
            int n = int.Parse(Console.ReadLine());

            Student[] vectorElevi = new Student[n];
            for (n = 0; n < vectorElevi.Length; n++)
            {
                vectorElevi[n] = CitesteElev();
            }
            foreach (Student students in vectorElevi)
            {
                students.TiparesteNume();
                students.TiparesteNota();
                Console.ReadLine();
                students.GetPremiantul();
            }

            Student student = CitesteElev();
            student.TiparesteNume();
            student.TiparesteNota();

            static Student CitesteElev()
            {
                Console.WriteLine("Introduceti Numele");
                string nume = Console.ReadLine();

                Console.WriteLine("Introduceti Prenumele");
                string prenume = Console.ReadLine();

                Console.WriteLine("Introduceti Numarul Notelor");
                int numarNote = int.Parse(Console.ReadLine());

                int[] note = new int[numarNote];
                Console.WriteLine("Introduceti Notele");
                for (var i = 0; i < note.Length; i++)
                {
                    Console.WriteLine("Introduceti Nota");
                    note[i] = int.Parse(Console.ReadLine());
                }

                Student student = new Student();
                student.nume = nume;
                student.prenume = prenume;
                student.note = note;
                return student;
            }
        }

        class Student
        {
            public string nume;
            public string prenume;
            public int[] note;

            public void TiparesteNume()
            {
                Console.WriteLine($"Ma numesc {nume} {prenume}");
            }

            public void TiparesteNota()
            {
                foreach (int nota in note)
                {
                    Console.WriteLine("Notele mele sunt:" + nota);
                }
            }
            public void GetPremiantul(double[] notaElevi)
            {
                string rezultat = String.Empty;
                double mediaMare = 0;
                for (int i = 0; i < notaElevi.Length; i++)
                {
                    double mediaCurenta = 0;
                    for (int j = 0; j < notaElevi[i].Length; j++)
                    {
                        mediaCurenta += notaElevi[i][j];
                        if (j == notaElevi[i].Length - 1)
                        {
                            mediaCurenta = mediaCurenta / notaElevi[i].Length;
                        }
                    }
                    if (mediaCurenta > mediaMare)
                    {
                        mediaMare = mediaCurenta;
                        rezultat = String.Empty;
                        rezultat = ($"Elevul {TiparesteNume()} are nota cea mai mare respectiv {mediaMare.ToString("n2")}.").ToString();
                    }
                }
            }
        }
    }
}
