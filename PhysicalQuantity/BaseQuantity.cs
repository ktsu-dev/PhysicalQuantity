namespace ktsu.io.PhysicalQuantity;

using System.Numerics;

public abstract record BaseQuantity<TSelf, TStorage>(TStorage Quantity)
	: PhysicalQuantity<TSelf, TStorage>(Quantity)
	where TSelf : BaseQuantity<TSelf, TStorage>
	where TStorage : INumber<TStorage>
{
}

public abstract record BaseQuantity<TSelf, TStorage, TIntegratesTo>(TStorage Quantity)
	: BaseQuantity<TSelf, TStorage>(Quantity)
	, IMultiplyOperators<BaseQuantity<TSelf, TStorage, TIntegratesTo>, TSelf, TIntegratesTo>
	where TSelf : BaseQuantity<TSelf, TStorage, TIntegratesTo>
	where TIntegratesTo : PhysicalQuantity<TIntegratesTo, TStorage>
	where TStorage : INumber<TStorage>
{
	public static TIntegratesTo operator *(BaseQuantity<TSelf, TStorage, TIntegratesTo> left, TSelf right) => Multiply<TIntegratesTo>(left, right);
}
