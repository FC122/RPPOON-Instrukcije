/*Napisite unit testove (pseudokod) koji provjerava ispravan rad s
     tri razlicita testna slucaja te objasnite koje slucajeve provjeravate 
     i zasto bas njih*/

// using NUnit.Framework;
// using System.Text;
// namespace SestiZadatakRjesenjeIspit4
// {
//     [TestFixture]
//     public class StringEncoderTests
//     {
//         [Test]
//         public void EncodeAsBinaryString_ThresholdBelowValues_ReturnsLowercaseString()
//         {
//             // Arrange
//             double threshold = 10;
//             List<double> values = new List<double> { 5, 7, 8 };

//             StringEncoder encoder = new StringEncoder(threshold);

//             // Act
//             string result = encoder.EncodeAsBinaryString(values);

//             // Assert
//             Assert.AreEqual("aaa", result);
//         }

//         [Test]
//         public void EncodeAsBinaryString_ThresholdAboveValues_ReturnsUppercaseString()
//         {
//             // Arrange
//             double threshold = 10;
//             List<double> values = new List<double> { 12, 15, 20 };

//             StringEncoder encoder = new StringEncoder(threshold);

//             // Act
//             string result = encoder.EncodeAsBinaryString(values);

//             // Assert
//             Assert.AreEqual("AAA", result);
//         }

//         [Test]
//         public void EncodeAsBinaryString_EmptyList_ReturnsEmptyString()
//         {
//             // Arrange
//             double threshold = 10;
//             List<double> values = new List<double>();

//             StringEncoder encoder = new StringEncoder(threshold);

//             // Act
//             string result = encoder.EncodeAsBinaryString(values);

//             // Assert
//             Assert.AreEqual("", result);
//         }
//     }
// }