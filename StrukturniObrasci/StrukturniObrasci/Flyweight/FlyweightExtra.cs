// namespace FlyweightExtra{
 

// interface ITextCharacter
// {
//     void Display(int fontSize);
// }

// class ConcreteTextCharacter : ITextCharacter
// {
//     private char character;
//     private string font;
//     private ConsoleColor color;

//     public ConcreteTextCharacter(char character, string font, ConsoleColor color)
//     {
//         this.character = character;
//         this.font = font;
//         this.color = color;
//     }

//     public void Display(int fontSize)
//     {
//         Console.ForegroundColor = color;
//         Console.WriteLine($"Character: {character}, Font: {font}, Size: {fontSize}");
//         Console.ResetColor();
//     }
// }

// class TextCharacterFactory
// {
//     private Dictionary<char, ITextCharactert> characters = new Dictionary<char, ITextCharacter>();

//     public ITextCharacter GetCharacter(char character, string font, ConsoleColor color)
//     {
//         if (!characters.ContainsKey(character))
//         {
//             characters[character] = new ConcreteTextCharacter(character, font, color);
//         }
//         return characters[character];
//     }
// }
// }