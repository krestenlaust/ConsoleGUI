namespace UI.Console.Tests
{
    [TestClass]
    public class RectangleSegmentTests
    {
        [TestMethod]
        public void TestSegmentCalculation2x2()
        {
            // arrange
            char[] fullarray = new char[] { 'A', 'B', 'C', 'D' };
            int fullarrayWidth = 2;
            int offsetX = 1;
            int offsetY = 1;
            int width = 1;
            int height = 1;

            // act
            RectangleSegment<char> segment = new(fullarray, fullarrayWidth, offsetX, offsetY, width, height);

            // assert
            Assert.AreEqual(fullarray[3], segment[0, 0]);
        }

        [TestMethod]
        public void TestSegmentModification2x2()
        {
            // arrange
            char[] fullarray = new char[] { 'A', 'B', 'C', 'D' };
            int fullarrayWidth = 2;
            int offsetX = 1;
            int offsetY = 1;
            int width = 1;
            int height = 1;

            // act
            RectangleSegment<char> segment = new(fullarray, fullarrayWidth, offsetX, offsetY, width, height);
            segment[0, 0] = 'C';

            // assert
            Assert.AreEqual('C', fullarray[3]);
            Assert.AreEqual(fullarray[3], segment[0, 0]);
        }
    }
}