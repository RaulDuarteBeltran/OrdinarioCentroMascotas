using System.Data.Common;
using MyProject.Enumeradores;

namespace MyProject.Interfaces;

public interface IMascota
{
    string Id { get; }
    string Nombre {get;}
    int Edad { get; }
    EspeciesEnum Especie {get;}
    TemperamentosEnum Temperamento {get;}
}