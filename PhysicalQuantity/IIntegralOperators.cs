namespace ktsu.io.PhysicalQuantity;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Generic;

public interface IIntegralOperators<TSelf, TOther, TResult>
	: IMultiplyOperators<TSelf, TOther, TResult>
	where TSelf : PhysicalQuantity<TSelf>, IIntegralOperators<TSelf, TOther, TResult>, new()
	where TOther : PhysicalQuantity<TOther>, new()
	where TResult : PhysicalQuantity<TResult>, new()
{
	public static TResult operator *(IIntegralOperators<TSelf, TOther, TResult> left, TOther right) => PhysicalQuantity<TSelf>.Multiply<TResult>((TSelf)left, right);
}
