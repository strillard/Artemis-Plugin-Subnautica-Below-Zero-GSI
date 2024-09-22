using Artemis.Core;
using Artemis.Core.Modules;
using Artemis.Core.Services;
using Artemis.Plugins.Modules.SubnauticaBelowZeroModule.DataModels;
using Serilog;
using System.Collections.Generic;

namespace Artemis.Plugins.Games.Modules.SubnauticaBelowZeroModule
{
    [PluginFeature(Name = "Subnautica Below Zero")]
    public class SubnauticaBelowZeroModule : Module<SubnauticaBelowZeroDataModel>
    {

        private readonly IWebServerService webServerService;
        private readonly ILogger logger;

        public SubnauticaBelowZeroModule(IWebServerService webServerService, ILogger logger)
        {
            this.webServerService = webServerService;
            this.logger = logger;
        }

        public override List<IModuleActivationRequirement> ActivationRequirements { get; } = new();

        public override void Enable()
        {

            webServerService.AddJsonEndPoint<SubnauticaBelowZeroDataModel>(this, "SubnauticaBelowZero", rep =>
            {
                DataModel.oxygen_available = rep.oxygen_available;
                DataModel.oxygen_capacity = rep.oxygen_capacity;
                DataModel.health = rep.health;
                DataModel.max_health = rep.max_health;
                DataModel.food = rep.food;
                DataModel.water = rep.water;
                DataModel.body_temperature = rep.body_temperature;
                DataModel.depth_level = rep.depth_level;
                DataModel.biome = rep.biome;
                DataModel.rain_intensity = rep.rain_intensity;
                DataModel.snow_intensity = rep.snow_intensity;
                DataModel.is_swimming = rep.is_swimming;
                DataModel.is_inside = rep.is_inside;
                DataModel.PDA_state = rep.PDA_state;
            });


        }

        public override void ModuleActivated(bool isOverride)
        {

        }

        public override void ModuleDeactivated(bool isOverride)
        {

        }


        public override void Disable()
        {

        }

        public override void Update(double deltaTime)
        {

        }
    }
}