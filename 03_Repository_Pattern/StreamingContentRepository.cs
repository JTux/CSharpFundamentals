using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Repository_Pattern
{
    public class StreamingContentRepository
    {
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();

        public void AddToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }

        public List<StreamingContent> GetStreamingContentList()
        {
            return _listOfContent;
        }

        public StreamingContent GetContentByName(string title)
        {
            StreamingContent content = new StreamingContent();

            foreach(StreamingContent sc in _listOfContent)
            {
                if(sc.Title == title)
                {
                    return sc;
                }
            }

            return content;
        }
    }
}
