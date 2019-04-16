using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Repository_Pattern
{
    public class StreamingContentQueueRepository
    {
        private Queue<StreamingContent> _contentQueue = new Queue<StreamingContent>();

        public void AddToQueue(StreamingContent content)
        {
            _contentQueue.Enqueue(content);
        }

        public StreamingContent GetNextContent()
        {
            StreamingContent nextContent = _contentQueue.Dequeue();
            return nextContent;
        }

        public StreamingContent PeekNextContent()
        {
            return _contentQueue.Peek();
        }

        public Queue<StreamingContent> GetContentQueue()
        {
            return _contentQueue;
        }

        public int GetQueueContentsCount()
        {
            int queueContentCount = _contentQueue.Count;
            return queueContentCount;
        }
    }
}
