﻿using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.ViewModels
{
   public class ProductView
   {
      public Guid Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public bool Gender { get; set; }
      public string Categories { get; set; }
      public string Size { get; set; }
      public int Price { get; set; }
      public double Rating { get; set; }
   }
}
