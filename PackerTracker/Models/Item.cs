using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class CampingItems
  {
    public string Item { get; set; }
    public int Price { get; set; }
    public int Weight { get; set; }
    public bool Packed { get; set; }
    public string Name { get; set; }
    public int Id { get; }
    

    private static List<CampingItems> _instances = new List<CampingItems> {};
    private static List<CampingItems> _unpackedItems = new List<CampingItems> {};




    public CampingItems (string item, int price, int weight, bool packed, string name)
    {
      Item = item;
      Price = price;
      Weight = weight;
      Packed = packed;
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<CampingItems> GetAll()
    {
      return _instances;
    }

    public static List<CampingItems> GetAllUnpackedItems()
    {
      return _unpackedItems;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}