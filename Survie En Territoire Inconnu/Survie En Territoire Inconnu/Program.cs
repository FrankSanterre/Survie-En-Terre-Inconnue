using System.Reflection;
using System.Security.Principal;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Survie_En_Territoire_Inconnu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            AfficherAccueil();
            AfficherIntroductionAuJeu();
            ExpliquerRegle();
            JouerUnTour();
            AfficherEcranVictoire();

                

            
        }
        public static void AfficherAccueil()
        {
            Console.CursorVisible = false;
            Console.WriteLine(" _____                  _        _____        _____                    _____                                       \r\n" +
                              "/  ___|                (_)      |  ___|      |_   _|                  |_   _|                                      \r\n" +
                              "\\ `--. _   _ _ ____   ___  ___  | |__ _ __     | | ___ _ __ _ __ ___    | | _ __   ___ ___  _ __  _ __  _   _  ___ \r\n" +
                              " `--. \\ | | | '__\\ \\ / / |/ _ \\ |  __| '_ \\    | |/ _ \\ '__| '__/ _ \\   | || '_ \\ / __/ _ \\| '_ \\| '_ \\| | | |/ _ \\\r\n" +
                              "/\\__/ / |_| | |   \\ V /| |  __/ | |__| | | |   | |  __/ |  | | |  __/  _| || | | | (_| (_) | | | | | | | |_| |  __/\r\n" +
                              "\\____/ \\__,_|_|    \\_/ |_|\\___| \\____/_| |_|   \\_/\\___|_|  |_|  \\___|  \\___/_| |_|\\___\\___/|_| |_|_| |_|\\__,_|\\___|\r\n                                                                                                                   \r\n                                                                                                                   ");
            Console.WriteLine("");
            for (; ; )
            {
                Console.WriteLine("                                        appuyez sur une touche pour commencer");
                Thread.Sleep(1000);
                ClearMessage();
                Thread.Sleep(500);
                if (!Console.KeyAvailable)
                {
                    continue;
                }
                else { break; }
               
            }
            AfficherBarreTelechargement();

        }
        public static void AfficherBarreTelechargement()
        {
            for (int i = 0;i < Console.WindowWidth/2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("Loading");
            Console.Write("[");
            for (int i = 0; i < Console.WindowWidth - 2; i++) 
            {
                Thread.Sleep(15);
                Console.Write("-");
                Thread.Sleep(15);
            }
            Console.Write("]");
        }
        public static void ClearMessage()
        {
            
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop -1 );
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor - 1);
        }
        public static void AfficherIntroductionAuJeu()
        {
            Console.Clear();
            string texteIntro = "Après tant de jours de travail, vos vacances étaient enfin arrivés. Vous étiez en route vers un paradis tropical.\n" +
                "Quand soudainement... Votre avion s'est écrasé dans un désert de glace.\n" +
                "Prit au piège vous devrez apprendre a survivre au coeur des étendues gelées... En terre inconnue";
            for (int i = 0;i < texteIntro.Length - 18;i++)
            {
                if (texteIntro[i] == '.')
                {
                    Thread.Sleep(1000);
                }
                Console.Write(texteIntro[i]);
                Thread.Sleep(50);
            }
            Thread.Sleep(1500);
            for (int i = 0;i < 18;i++)
            {
                Thread.Sleep(200);
                Console.Write(texteIntro[i + (texteIntro.Length - 18)]);
            }
            Thread.Sleep(1000);
        }
        public static void ExpliquerRegle()
        {
            Console.Clear();
            string texteTutoriel = "Vous devrez construire une maison pour survivre au froid en attendant les secours.\n" +
                "Pour construire votre maison, vous allez devoir recolter plusieurs ressources provenants de biômes variés,\n" +
                "que vous allez découvrir en explorant vos alentours.\n" +
                "À chaque tours vous serez confronté à des choix difficiles.\n" +
                "Lors d'un tour, vous avez la possibilité de vous déplacer ou de récolter les ressources" +
                "de votre biôme actuel en appuyant sur la barre d'espace. ";
            for (int i = 0; i < texteTutoriel.Length; i++)
            {
                if (texteTutoriel[i] == '.')
                {
                    Thread.Sleep(1000);
                }
                Console.Write(texteTutoriel[i]);
                Thread.Sleep(50);
            }
        }
        public static void JouerUnTour()
        {
            int positionX = 0;
            int positionY = 0;
            int 
            string biome = "maison";
            for (; ; )
            {
                Console.WriteLine("Votre position actuelle [" + positionX + "," + positionY + "] Type de terrain:" + biome);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Utilisez les flèches pour vous déplacer et la barre d'espace pour miner");
                Console.ForegroundColor = ConsoleColor.White;
                if ( Console.ReadKey().Key == ConsoleKey.LeftArrow)
                {
                    positionX--;
                }
                else if (Console.ReadKey().Key == ConsoleKey.RightArrow)
                {
                    positionX++;
                }
                else if (Console.ReadKey().Key == ConsoleKey.DownArrow)
                {
                    positionY--;
                }
                else if (Console.ReadKey().Key == ConsoleKey.UpArrow)
                {
                    positionY++;
                }
                else if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    if (biome == "maison")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vous êtes au site du crash, il n'y a rien à récolter");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (biome == "montagne")
                    {
                         
                    }
                }
                Console.Clear();
            }
        }
        public static void AfficherEcranVictoire()
        {

        }
    }
}