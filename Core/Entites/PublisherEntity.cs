﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class PublisherEntity
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("publisher_name", TypeName = "varchar(100)")]
        public string Name { get; set; }
        public ISet<GamePublisherEntity> GamesPublishers { get; set; } = new HashSet<GamePublisherEntity>();
    }
}
