using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model;

public class PassengerInfo
{
    public int Id { get; set; }
    public Flight Flight { get; set; }
    public int EconomySeatsOccupied { get; set; }
    public int BusinessSeatsOccupied { get; set; }
}
