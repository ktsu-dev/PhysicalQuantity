namespace ktsu.io.PhysicalQuantity;

using System.Numerics;

public abstract record DerivedQuantity<TSelf, TStorage, TDerivesFrom, TBaseQuantity>(TStorage Quantity)
	: PhysicalQuantity<TSelf, TStorage>(Quantity)
	, IDivisionOperators<DerivedQuantity<TSelf, TStorage, TDerivesFrom, TBaseQuantity>, TBaseQuantity, TDerivesFrom>
	where TSelf : DerivedQuantity<TSelf, TStorage, TDerivesFrom, TBaseQuantity>
	where TDerivesFrom : PhysicalQuantity<TDerivesFrom, TStorage>
	where TBaseQuantity : PhysicalQuantity<TBaseQuantity, TStorage>
	where TStorage : INumber<TStorage>
{
	public static TDerivesFrom operator /(DerivedQuantity<TSelf, TStorage, TDerivesFrom, TBaseQuantity> left, TBaseQuantity right) => Divide<TDerivesFrom>(left, right);
}

public abstract record DerivedQuantity<TSelf, TStorage, TDerivesFrom, TIntegratesTo, TBaseQuantity>(TStorage Quantity)
	: DerivedQuantity<TSelf, TStorage, TDerivesFrom, TBaseQuantity>(Quantity)
	, IMultiplyOperators<DerivedQuantity<TSelf, TStorage, TDerivesFrom, TIntegratesTo, TBaseQuantity>, TBaseQuantity, TIntegratesTo>
	where TSelf : DerivedQuantity<TSelf, TStorage, TDerivesFrom, TIntegratesTo, TBaseQuantity>
	where TDerivesFrom : PhysicalQuantity<TDerivesFrom, TStorage>
	where TIntegratesTo : PhysicalQuantity<TIntegratesTo, TStorage>
	where TBaseQuantity : PhysicalQuantity<TBaseQuantity, TStorage>
	where TStorage : INumber<TStorage>
{
	public static TIntegratesTo operator *(DerivedQuantity<TSelf, TStorage, TDerivesFrom, TIntegratesTo, TBaseQuantity> left, TBaseQuantity right) => Multiply<TIntegratesTo>(left, right);
}


