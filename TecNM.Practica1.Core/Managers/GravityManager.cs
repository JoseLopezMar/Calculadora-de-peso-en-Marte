using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Managers;

public class GravityManager : IGravityManager {
    private readonly IGravityService _service;

    public GravityManager(IGravityService service){
        _service = service;
    }

    public Gravity getGravity(Person person){
        return _service.processGravity(person);
    }
}