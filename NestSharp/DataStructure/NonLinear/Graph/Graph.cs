namespace NestSharp.DataStructure;

public class Graph<TVertex> : IGraph<TVertex, Edge<TVertex>> {

	//======================================================================| Fields

	private readonly HashSet<TVertex> _vertices = [];
	private readonly HashSet<Edge<TVertex>> _edges = [];

	//======================================================================| Properties

	public IReadOnlySet<TVertex> Vertices => _vertices;
	public IReadOnlySet<Edge<TVertex>> Edges => _edges;

}
