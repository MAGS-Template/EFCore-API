using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
    public class Post : Common
    {
        public string imageURL {  get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
