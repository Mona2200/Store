namespace Store.Models
{
   public class Address
   {
      public string Region { get; set; }
      public string Town { get; set; }
      public string Outside { get; set; }
      public string House { get; set; }
      public uint Flat { get; set; }
      public uint Postcode { get; set; }
   }
}