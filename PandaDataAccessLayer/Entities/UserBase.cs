﻿using PandaDataAccessLayer.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaDataAccessLayer.Entities
{
    public abstract class UserBase : IGuidIdentifiable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Number { get; set; }

        public virtual SeoEntry SeoEntry { get; set; }
        public virtual Photo Avatar { get; set; }

        public virtual ICollection<Checklist> Checklists { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public UserBase() 
        {
            if (Checklists == null)
                Checklists = new List<Checklist>();
            if (Sessions == null)
                Sessions = new List<Session>();
            if (Albums == null)
                Albums = new List<Album>();
            if (Reviews == null)
                Reviews = new List<Review>();
        }
    }
}
