﻿using MvcComEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcComWeb.ViewModel
{
    public class HomeViewModels
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

    }
}