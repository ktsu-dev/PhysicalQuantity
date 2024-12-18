namespace ktsu.PhysicalQuantity;

using System.Numerics;
using ktsu.PhysicalQuantity.Generic;

public interface IDerivativeOperators<TSelf, TOther, TResult>
	: IDivisionOperators<TSelf, TOther, TResult>
	where TSelf : PhysicalQuantity<TSelf>, IDerivativeOperators<TSelf, TOther, TResult>, new()
	where TOther : PhysicalQuantity<TOther>, new()
	where TResult : PhysicalQuantity<TResult>, new()
{
	public static TResult Derive(TSelf left, TOther right) =>
		PhysicalQuantity<TSelf>.Divide<TResult>(left, right);
}
