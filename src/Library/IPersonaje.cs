using System.Collections.Generic;

namespace Program
{
    public interface IPersonaje
    {
        const int K_AtaqueBase = 5;

        const int K_DefensaBase = 2;

        const int K_maxHP = 100;

        string Nombre{get; set;}

        int HP{get; set;}

        List<IItem> Inventario{get;}

        void AddItem(IItem item);

        void RemoveItem(IItem item);

        IAttack Arma{get;}

        IDefense Armadura{get;}

        int Ataque {get;}

        int Defensa {get;}

    }
}

