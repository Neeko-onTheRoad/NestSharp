namespace NestSharp.DataStructure;

public interface IReadOnlyGraph<TVertex, TEdge>
	where TEdge : IReadOnlyEdge<TVertex>
{

	public IReadOnlySet<TVertex> Vertices { get; }
	public IReadOnlySet<TEdge> Edges { get; } 

}
