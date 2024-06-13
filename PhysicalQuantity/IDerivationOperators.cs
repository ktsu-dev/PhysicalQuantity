namespace ktsu.io.PhysicalQuantity;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Generic;

public interface IDerivationOperators<TSelf, TOther, TResult>
	: IDivisionOperators<TSelf, TOther, TResult>
	where TSelf : PhysicalQuantity<TSelf>, IDerivationOperators<TSelf, TOther, TResult>, new()
	where TOther : PhysicalQuantity<TOther>, new()
	where TResult : PhysicalQuantity<TResult>, new()
{
	public static TResult operator /(IDerivationOperators<TSelf, TOther, TResult> left, TOther right) => PhysicalQuantity<TSelf>.Divide<TResult>((PhysicalQuantity<TSelf>)left, right);
}
