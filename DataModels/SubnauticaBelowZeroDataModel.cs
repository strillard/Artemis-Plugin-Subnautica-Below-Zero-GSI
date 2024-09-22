using Artemis.Core.Modules;

namespace Artemis.Plugins.Modules.SubnauticaBelowZeroModule.DataModels
{
    public class SubnauticaBelowZeroDataModel : DataModel
    {
        public float oxygen_available { get; set; }
        public float oxygen_capacity { get; set; }
        public float health { get; set; }
        public float max_health { get; set; }
        public float food { get; set; }
        public float water { get; set; }
        public float body_temperature { get; set; }
        public float depth_level { get; set; }
        public string biome { get; set; }
        public float rain_intensity { get; set; }
        public float snow_intensity { get; set; }
        public bool is_swimming { get; set; }
        public bool is_inside { get; set; }
        public PDAState PDA_state { get; set; }
    }
    public enum PDAState
    {
        Opened,
        Closed,
        Opening,
        Closing
    }
}