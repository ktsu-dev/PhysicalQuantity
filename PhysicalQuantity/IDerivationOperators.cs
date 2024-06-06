namespace ktsu.io.PhysicalQuantity;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Generic;

public interface IDerivationOperators<TSelf, TStorage, TOther, TResult>
	: IDivisionOperators<TSelf, TOther, TResult>
	where TSelf : PhysicalQuantity<TSelf, TStorage>, IDerivationOperators<TSelf, TStorage, TOther, TResult>, new()
	where TOther : PhysicalQuantity<TOther, TStorage>, new()
	where TResult : PhysicalQuantity<TResult, TStorage>, new()
	where TStorage : INumber<TStorage>
{
	public static TResult operator /(IDerivationOperators<TSelf, TStorage, TOther, TResult> left, TOther right) => PhysicalQuantity<TSelf, TStorage>.Divide<TResult>((PhysicalQuantity<TSelf, TStorage>)left, right);
}
