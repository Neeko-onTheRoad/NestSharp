namespace NestSharp.DataStructure;

public interface IGraph<TVertex, TEdge> : IReadOnlyGraph<TVertex, TEdge>
	where TEdge : IEdge<TVertex>
{

	

}
