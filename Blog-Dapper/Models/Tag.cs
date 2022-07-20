﻿using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace Blog_Dapper.Models
{
    [Table("[Tag]")]
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        [Write(false)]
        public List<Post> Roles { get; set; }
    }
}
