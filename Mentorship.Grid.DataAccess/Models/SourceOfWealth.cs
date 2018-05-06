using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Mentorship.Grid.DataAccess.Interfaces;
using Newtonsoft.Json;

namespace Mentorship.Grid.DataAccess.Models
{
    [DataContract(Name = "SourcesOfWealth")]
    public class SourceOfWealth : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        [JsonProperty]
        public int Id { get; set; }
        [Required]
        [DataMember]
        [JsonProperty]
        public DateTime CreatedOn { get; set; }
        [Required]
        [DataMember]
        [JsonProperty]
        public DateTime ModifiedOn { get; set; }
        [Required]
        [DataMember]
        [JsonProperty]
        public string CompanyName { get; set; }
       // [DataMember]
        [JsonIgnore]
        public ICollection<Billionaire> Billionaires { get; set; }

        //public SourceOfWealth()
        //{
        //    Billionaires = new List<Billionaire>();
        //}
    }
}
