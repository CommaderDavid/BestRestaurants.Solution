using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public int CuisineId { get; set; }
    public string CuisineName { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }  //imaginary list

    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }
  }
}