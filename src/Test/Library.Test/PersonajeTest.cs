using NUnit.Framework;
using Program;

namespace Test.Library
{
    [TestFixture]

    public class PersonajeTest
    {
      [Test]
      public void ConstruirPersonajeTest()
      {
        Mago p = new Mago("Messi");
        string expectedName = "Messi";

        Assert.AreSame(expectedName, p.Nombre);

        Elfo p = new Elfo("Messi");
        Assert.AreSame(expectedName, p.Nombre);

        Enano p = new Enano("Messi");
        Assert.AreSame(expectedName, p.Nombre);
      }

      [Test]
      public void AddItemTest()
      {
        Elfo p = new Elfo("Messi");
        Espada i = new Espada("Espada de Diamante", 16);

        p.AddItem(i);
        bool IteminInventario = p.Inventario.Contains(i);
        Assert.IsTrue(IteminInventario);
      }

      [Test]
      public void RemoveItemTest()
      {
        Elfo p = new Elfo("Messi");
        Espada i = new Espada("Espada de Diamante", 16);

        p.AddItem(i);
        p.RemoveItem(i);
        bool IteminInventario = p.Inventario.Contains(i);

        Assert.IsFalse(IteminInventario);
      }

      [Test]
      public void ArmaTest()
      {
        Elfo p = new Elfo("Messi");
        Espada i = new Espada("Espada de Diamante", 16);

        p.AddItem(i);

        Assert.AreSame(i, p.Arma);
      }

      [Test]
      public void HPTest()
      {
        Elfo p = new Elfo("Messi");

        p.HP = -20;

        int ExpectedHP = 0;

        Assert.AreEqual(ExpectedHP, p.HP);
      }

      [Test]
      public void AtaqueTest()
      {
        Elfo p = new Elfo("Messi");
        Espada i = new Espada("Espada de Diamante", 16);
        Espada e = new Espada("Espada de Plata", 20);

        p.AddItem(i);
        p.AddItem(e);

        int ExpectedAtaque = 25;

        Assert.AreEqual(ExpectedAtaque, p.Ataque);
      }

      [Test]
      public void DefensaTest()
      {
        Elfo p = new Elfo("Messi");
        Pechera i = new Pechera("Armadura de Cuero", 16);
        Pechera e = new Pechera("Armadura de Oro", 20);

        p.AddItem(i);
        p.AddItem(e);

        int ExpectedDefensa = 4;

        Assert.AreEqual(ExpectedDefensa, p.Defensa);
      }

      [Test]
      public void LibroEquipadoTest(){
        Mago p = new Mago("Messi");
        Libro i = new Libro("El Principito");

        p.AddItem(i);

        Assert.AreSame(i, p.LibroEquipado);
      }

    }
}