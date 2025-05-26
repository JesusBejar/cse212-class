public class FeatureCollection
{
    // drill down from features to get mag, place, etc
    public string Type { get; set; }
    public Feature[] Features { get; set; }
}

public class Feature
{
    public string Type { get; set; }
    public Properties Properties { get; set; }
    public object Geometry { get; set; } 
    public string Id { get; set; }
}

public class Properties
{
    public double Mag { get; set; }  
    public string Place { get; set; }    
    public long Time { get; set; }      
}