using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
   public class RatingDto
    {
        public decimal Rate { get; set; } = default!;
        public int Count { get; set; } = default!;
    }
}
