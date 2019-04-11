using System;
using System.Collections.Generic;
using _03_Repository_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Repository_Pattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void StreamingContentAddToListTest()
        {
            // Arrange
            StreamingContentRepository streamRepo = new StreamingContentRepository();
            StreamingContent content = new StreamingContent("It", 3, GenreType.Horror, true, "PG", 6.5d);

            // Act
            streamRepo.AddToList(content);
            List<StreamingContent> list = streamRepo.GetStreamingContentList();

            int actual = list.Count;
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(list.Contains(content));
        }
    }
}
