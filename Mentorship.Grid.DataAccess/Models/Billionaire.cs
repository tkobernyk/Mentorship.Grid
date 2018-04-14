using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Mentorship.Grid.DataAccess.Interfaces;
using Newtonsoft.Json;

namespace Mentorship.Grid.DataAccess.Models
{
    [DataContract(Name = "Billionaires")]
    public class Billionaire : IEntity
    {
        [Key]
        [DataMember]
        [JsonProperty]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public int Position { get; set; }
        [Required]
        [MaxLength(50)]
        [DataMember]
        [JsonProperty]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        [DataMember]
        [JsonProperty]
        public string LastName { get; set; }
        [Required]
        [DataMember]
        [JsonProperty]
        public decimal NetWorth { get; set; }
        [Required]
        [DataMember]
        [JsonProperty]
        public int Age { get; set; }
        [Required]
        [MaxLength(50)]
        [DataMember]
        [JsonProperty]
        public string Nationality { get; set; }
        [DataMember]
        [JsonProperty]
        public ICollection<SourceOfWealth> SourcesOfWealth { get; set; }
    }
}
