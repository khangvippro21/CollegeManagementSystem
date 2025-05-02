using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    internal class ReviewDTO
    {

        public int ReviewId { get; set; } // INT IDENTITY
        public string StId { get; set; }
        public string LeId { get; set; }
        public string CId { get; set; }
        public string Comment { get; set; }

        public ReviewDTO(string stId, string leId, string cId, string comment)
        {
            StId = stId;
            LeId = leId;
            CId = cId;
            Comment = comment;
        }

        public ReviewDTO(int reviewId, string stId, string leId, string cId, string comment)
        {
            ReviewId = reviewId;
            StId = stId;
            LeId = leId;
            CId = cId;
            Comment = comment;
        }
    }
}
