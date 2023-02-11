using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Enums;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Services;

public class GravityService : IGravityService {
    public Gravity processGravity(Person person){
        var gravity = new Gravity();
        gravity.Index = person.weight / 9.81 * 3.711;
        gravity.GravityType = GravityType.Marte;
        return gravity;
    }
}