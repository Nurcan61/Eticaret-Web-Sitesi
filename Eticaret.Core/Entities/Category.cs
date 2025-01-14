﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    public class Category : IEntity
    {
        public int ıd { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Isactive { get; set; }

        public bool IsTopMenu { get; set; }
        public int ParentId { get; set; }
        public int OrderNo { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public IList<Product>? Products { get; set; }
    }
}
