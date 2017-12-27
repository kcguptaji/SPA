﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Entities
{
    public class Genre: IEntityBase
    {
        public Genre()
        {
            Movies =new List<Movie>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

    }
}
