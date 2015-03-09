﻿using Sopo.Repository.BaseTypes;
using Sopo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository
{
    public class Picture : BaseRateable
    {
        public string Description { get; set; }
        //public byte[] Image { get; set; }
        //public Path FilePath { get; set; }
        public string FileName { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Library Library { get; set; }
    }
}