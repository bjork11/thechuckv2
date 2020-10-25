using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace thechuckv2.Dto
{
    public class SearchResult
    {
        public int total;
        public List<JokeDto> result { get; set; }
    }
}
