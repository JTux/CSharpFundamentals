using System;
using _03_Repository_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Repository_Pattern_Tests
{
    [TestClass]
    public class StreamingContentQueueTests
    {
        [TestMethod]
        public void StreamingContent_AddToQueue_ShouldSeeContentOnQueue()
        {
            // Arrange
            StreamingContentQueueRepository queueRepo = new StreamingContentQueueRepository();
            StreamingContent content = new StreamingContent("It", 3, GenreType.Horror, true, "PG", 6.5d);

            // Act
            queueRepo.AddToQueue(content);
            StreamingContent queueContent = queueRepo.PeekNextContent();

            // Assert
            Assert.AreSame(content, queueContent);
        }

        [TestMethod]
        public void StreamingContent_GetQueueCount_ShouldReturnCorrectInt()
        {
            // Arrange
            StreamingContentQueueRepository queueRepo = new StreamingContentQueueRepository();
            StreamingContent content = new StreamingContent("It", 3, GenreType.Horror, true, "PG", 6.5d);

            // Act
            queueRepo.AddToQueue(content);
            queueRepo.AddToQueue(content);
            queueRepo.AddToQueue(content);
            queueRepo.AddToQueue(content);

            var expected = 4;
            var actual = queueRepo.GetQueueContentsCount();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
