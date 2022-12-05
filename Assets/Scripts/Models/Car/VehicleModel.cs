using System.Collections.Generic;

public class VehicleModel
{
    public BrandModel brand;
    //This is going to get a mesh from the marketplace
    public string colour { get; set; }
    public EngineModel engine;
    public int wheels { get; set; }
    //Add suspension
    public TyresModel tyre;
    public List<AttributeModel> attributes;
    // public 

    public void InitState()
    {
        for (int i = 0; i < wheels; i++)
        {
            //Set config for wheels
        }
    }


    public void Honk()
    {

    }
}
