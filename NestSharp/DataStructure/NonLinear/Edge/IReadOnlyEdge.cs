namespace NestSharp.DataStructure;

public interface IReadOnlyEdge<out TVertex> {
	
	public TVertex Start { get; }
	public TVertex End { get; }

}
