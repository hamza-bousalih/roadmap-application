using Lamar;
using RoadMapApp.utils.service;
using RoadMapApp.Models;
using RoadMapApp.Repository;
using RoadMapApp.Repository.OptionRepository;
using RoadMapApp.utils.service.ModuleService;

namespace RoadMapApp.Services.OptionService
{
    public class OptionService : ModuleService<Option, IOptionRepository>, IOptionService
    {
        public OptionService(IContainer container) : base(container)
        {
        }
    }
}