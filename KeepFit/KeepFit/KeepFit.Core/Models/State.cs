﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KeepFit.Core.Models
{
    public class State : AuditableEntity
    {
        public State()
        {
            Addresses = new List<Address>();
        }

        public int StateId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "abbreviation")]
        public string ShortName { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public override int Id
        {
            get { return StateId; }
        }
    }
}