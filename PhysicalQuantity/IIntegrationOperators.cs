namespace ktsu.io.PhysicalQuantity;

using System.Numerics;

public interface IIntegrationOperators<TSelf, TStorage, TOther, TResult>
	: IMultiplyOperators<TSelf, TOther, TResult>
	where TSelf : PhysicalQuantity<TSelf, TStorage>, IIntegrationOperators<TSelf, TStorage, TOther, TResult>
	where TOther : PhysicalQuantity<TOther, TStorage>
	where TResult : PhysicalQuantity<TResult, TStorage>
	where TStorage : INumber<TStorage>
{
	public static TResult operator *(IIntegrationOperators<TSelf, TStorage, TOther, TResult> left, TOther right) => PhysicalQuantity<TSelf, TStorage>.Multiply<TResult>((PhysicalQuantity<TSelf, TStorage>)left, right);
}
