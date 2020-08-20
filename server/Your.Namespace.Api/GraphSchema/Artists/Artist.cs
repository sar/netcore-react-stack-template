using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.AspNetCore.Authorization;
using Your.Namespace.Api.GraphSchema.Albums;

namespace Your.Namespace.Api.GraphSchema.Artists
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Authorize(Policy = Policies.God)]
        public double TotalRevenue { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}