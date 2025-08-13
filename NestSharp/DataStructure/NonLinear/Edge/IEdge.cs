namespace NestSharp.DataStructure;

public interface IEdge<TVertex> : IReadOnlyEdge<TVertex> {

	public new TVertex Start { get; set; }
	public new TVertex End { get; set; }

}
