using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model;

public class Flight
{
    [Key]
    [Column(TypeName = "nvarchar(20)")]
    public string Flightnumber { get; set; }
    [Column(TypeName = "nvarchar(200)")]
    public string Arrival { get; set; }
    [Column(TypeName = "nvarchar(200)")]
    public string Departure { get; set; }
    public int PilotId { get; set; }
    [Required]
    public Pilot Pilot { get; set; }
    public Pilot CoPilot { get; set; }
    public int AirplaneId { get; set; }
    [Required]
    public Airplane Airplane { get; set; }
    public ICollection<CabinMember> CabinMembers { get; set; }
    public int? PassengerInfoId { get; set; }
    public PassengerInfo PassengerInfo { get; set; }
}
