using System;
//Kommenteritud
namespace Factory
{

	class MainApp
	{
		
		static void Main()
		{
            //Luuakse jada "creators", mis koosneb kahest liikmest:
			Creator[] creators = new Creator[2];
			//Need 2 jada liiget, mis tekitavad 2 uut konkreetset "creatorit", vastavalt Creatori alamklassidele ConcreteCreatorA ja ConcreteCreatorB.
			creators[0] = new ConcreteCreatorA();
			creators[1] = new ConcreteCreatorB();

            //Läbi foreach tsükli luuakse tooted, prinditakse konsoolile toote nimi
			foreach (Creator creator in creators)
			{
				Product product = creator.FactoryMethod();
				Console.WriteLine("Created {0}",
				  product.GetType().Name);
			}

			

			Console.ReadLine();
		}
	}

    //Abstraktne tühi klass (liides) Toode, mis kirjutatakse üle, on ülemklassiks ConcreteProductA ja ConcreteProductB klassidele, seob need.
	abstract class Product
	{
	}

    //Toote alamklassid ConcreteProductA ja ConcreteProductB, sisuliselt ka liidesed
	class ConcreteProductA : Product
	{
	}
   
	class ConcreteProductB : Product
	{
	}

    //Abstraktne klass Creator, mis sisaldab ülekirjutatavat meetodit "Toode"
	abstract class Creator
	{
		public abstract Product FactoryMethod();
	}

    //"Creatori" alamklass, pärib ülemklassilt meetodi, 
    //mis kirjutatakse üle konkreetse alamklassi poolt ConcreteCreatorA ning tagastab konkreetse toote A:
	class ConcreteCreatorA : Creator
	{
		public override Product FactoryMethod()
		{
			return new ConcreteProductA();
		}
	}
	//"Creatori" alamklass, pärib ülemklassilt meetodi, 
    //mis kirjutatakse üle konkreetse alamklassi poolt ConcreteCreatorB ning tagastab konkreetse toote B:
	class ConcreteCreatorB : Creator
	{
		public override Product FactoryMethod()
		{
			return new ConcreteProductB();
		}
	}
}