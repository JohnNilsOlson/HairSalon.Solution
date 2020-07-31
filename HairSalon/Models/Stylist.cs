using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string FristName { get; set; }
    public string LastName { get; set; }
    public virtual ICollection<Stylist> Stylists { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
  }
}