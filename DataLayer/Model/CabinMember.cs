using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model;

public class CabinMember
{
    public int Id { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(200)")]
    public string Name { get; set; }
    public int AirlineId { get; set; }
    [Required]
    public Airline Airline { get; set; }
    public ICollection<Flight> Flights { get; set; }
}
