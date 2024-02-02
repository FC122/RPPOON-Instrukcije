// using NUnit.Framework;
// using System.Collections.Generic;

// namespace SestiZadatakIspit5.Tests
// {
//     [TestFixture]
//     public class LengthEncoderTests
//     {
//         [Test]
//         public void Encode_LengthBelowCutoff_ReturnsInvalidCode()
//         {
//             // Arrange
//             char validCode = 'V';
//             char invalidCode = 'I';
//             int lengthCutoff = 5;
//             LengthEncoder encoder = new LengthEncoder(validCode, invalidCode, lengthCutoff);
//             List<string> words = new List<string> { "apple", "banana", "orange" };

//             // Act
//             string result = encoder.Encode(words);

//             // Assert
//             Assert.AreEqual("IIIII", result);
//         }

//         [Test]
//         public void Encode_LengthAboveCutoff_ReturnsValidCode()
//         {
//             // Arrange
//             char validCode = 'V';
//             char invalidCode = 'I';
//             int lengthCutoff = 5;
//             LengthEncoder encoder = new LengthEncoder(validCode, invalidCode, lengthCutoff);
//             List<string> words = new List<string> { "pineapple", "grapefruit", "watermelon" };

//             // Act
//             string result = encoder.Encode(words);

//             // Assert
//             Assert.AreEqual("VVVVVVV", result);
//         }
//     }
// }
