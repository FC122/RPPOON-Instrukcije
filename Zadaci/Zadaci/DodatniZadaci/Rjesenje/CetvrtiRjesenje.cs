/*
Za primjer dan izlistanjem kôda odredite obrazac o kojem 
je riječ i njegovu skupinu. Dopunite kôd implementacijom 
koja nedostaje te napišite klijentski kôd za ovaj primjer.
*/
/*Flyweight*/
namespace CetvrtiRjesenje
{
    interface ITextCharacter
    {
        void Display(int fontSize);
    }

    class ConcreteTextCharacter : ITextCharacter
    {
        private char character;
        private string font;
        private ConsoleColor color;

        public ConcreteTextCharacter(char character, string font, ConsoleColor color)
        {
            this.character = character;
            this.font = font;
            this.color = color;
        }

        public void Display(int fontSize)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Character: {character}, Font: {font}, Size: {fontSize}");
            Console.ResetColor();
        }
    }

    class TextCharacterFactory
    {
        private Dictionary<char, ITextCharacter> characters = new Dictionary<char, ITextCharacter>();

        public ITextCharacter GetCharacter(char character, string font, ConsoleColor color)
        {
            if (!characters.ContainsKey(character))
            {
                characters[character] = new ConcreteTextCharacter(character, font, color);
            }
            return characters[character];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Klijentski kod
            TextCharacterFactory factory = new TextCharacterFactory();

            ITextCharacter charA = factory.GetCharacter('A', "Arial", ConsoleColor.Red);
            charA.Display(12);

            ITextCharacter charB = factory.GetCharacter('B', "Times New Roman", ConsoleColor.Blue);
            charB.Display(14);
        }
    }
}