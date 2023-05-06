using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model;

public class Airline
{
    public int Id { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(250)")]
    public string Name { get; set; }
    public ICollection<Pilot> Pilots { get; set; }
    public ICollection<CabinMember> CabinMembers { get; set; }
}
