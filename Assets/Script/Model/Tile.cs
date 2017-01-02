using System.Collections;

public class Tile {

	World world;
	int x;
	public int X {
		get {
			return x;
		}
	}
	int y;
	public int Y {
		get {
			return y;
		}
	}

	public Tile(World world, int x, int y) {
		this.world = world;
		this.x = x;
		this.y = y;
	}
}

