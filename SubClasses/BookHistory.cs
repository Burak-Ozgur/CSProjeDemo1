using CSProjeDemo1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.SubClasses
{
    public class BookHistory : Book
    {
        public List<TopicField>? TopicField { get; set; }
        public List<Era>? Era { get; set; }
        public List<Geography>? Geography { get; set; }
    }
}
