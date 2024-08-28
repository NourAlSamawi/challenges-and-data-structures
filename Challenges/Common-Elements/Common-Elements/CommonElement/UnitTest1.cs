using Microsoft.VisualStudio.TestPlatform.TestHost;
using Common_Elements;

namespace CommonElement
{
    public class UnitTest1
    {
        [Fact]
        public void CommonElements_WithCommonElements_ReturnsCommonElements()
        {
            // Arrange
            int[] array1 = { 1, 2, 3, 0 };
            int[] array2 = { 2, 3, 4, 9 };

            // Act
            int[] result = Common_Elements.Program.CommonElements(array1, array2);

            // Assert
            Assert.Equal(new[] { 2, 3 }, result);
        }

        [Fact]
        public void CommonElements_WithSomeCommonElements_ReturnsCorrectCommonElements()
        {
            // Arrange
            int[] array1 = { 79, 8, 15 };
            int[] array2 = { 23, 79, 8 };

            // Act
            int[] result = Common_Elements.Program.CommonElements(array1, array2);

            // Assert
            Assert.Equal(new[] { 79, 8 }, result);
        }
    }
}