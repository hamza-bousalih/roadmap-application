using Lamar;
using RoadMapApp.Models;
using RoadMapApp.Repository.SectionRepository;
using RoadMapApp.utils.service;
using RoadMapApp.utils.service.ModuleService;

namespace RoadMapApp.Services.SectionService;

public class SectionService: ModuleService<Section, ISectionRepository>, ISectionService
{
    public SectionService(IContainer container): base(container)
    {
    }
}