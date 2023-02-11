namespace TecNM.Practica1.Core.Managers.Interfaces;

using TecNM.Practica1.Core.Entities;

public interface IGravityManager {
    Gravity getGravity (Person person);
}