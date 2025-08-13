namespace NestSharp.DataStructure;

public record class Edge<TVertex> : IEdge<TVertex> {

	public Edge(TVertex start, TVertex end) {
		Start = start;
		End = end;
	}

	public virtual TVertex Start { get; set; } 
	public virtual TVertex End { get; set; }

}
