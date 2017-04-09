﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWeb.Responses
{
    public class ProductDetailResponse
    {
        public int ProductId { get; set; }

        public string ArticleNo { get; set; }

        public string Name { get; set; }

        public string ImageName { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
    }
}
