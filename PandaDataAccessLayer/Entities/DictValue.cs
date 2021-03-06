﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaDataAccessLayer.Entities
{
    public class DictValue : IGuidIdentifiable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid DictGroupId { get; set; }

        [Required]
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual DictGroup DictGroup { get; set; }
    }
}
