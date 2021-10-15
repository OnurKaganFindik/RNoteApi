using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RNoteApi.Data
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedTime { get; set; } = DateTime.Now;
        public DateTime ModifiedTime { get; set; }
    }
}
