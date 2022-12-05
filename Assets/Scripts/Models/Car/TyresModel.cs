using System.Collections.Generic;

public class TyresModel : ItemModel
{
    public string type { get; set; }
    public string description { get; set; }
    public string name { get; set; }
    public string size { get; set; }
    public List<TerrainModel> terrain;
    public RimModel rim;
}
