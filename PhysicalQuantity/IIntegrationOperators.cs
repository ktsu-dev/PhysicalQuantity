// Ignore Spelling: ktsu

namespace ktsu.io.PhysicalQuantity;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Generic;

public interface IIntegrationOperators<TSelf, TStorage, TOther, TResult>
	: IMultiplyOperators<TSelf, TOther, TResult>
	where TSelf : PhysicalQuantity<TSelf, TStorage>, IIntegrationOperators<TSelf, TStorage, TOther, TResult>, new()
	where TOther : PhysicalQuantity<TOther, TStorage>, new()
	where TResult : PhysicalQuantity<TResult, TStorage>, new()
	where TStorage : INumber<TStorage>
{
	public static TResult operator *(IIntegrationOperators<TSelf, TStorage, TOther, TResult> left, TOther right) => PhysicalQuantity<TSelf, TStorage>.Multiply<TResult>((PhysicalQuantity<TSelf, TStorage>)left, right);
}
