public class BoardPanel {
    // tag::render[]
    /**
     * Renders a single square on the given graphics context on the specified
     * rectangle.
     * 
     * @param square
     *            The square to render.
     * @param g
     *            The graphics context to draw on.
     * @param x
     *            The x position to start drawing.
     * @param y
     *            The y position to start drawing.
     * @param w
     *            The width of this square (in pixels).
     * @param h
     *            The height of this square (in pixels).
     */
    private void render(Square square, Graphics graphics) {
        square.sprite.draw(graphics);
        foreach (Unit unit in square.getOccupants()) {
            unit.sprite.draw(graphics);
        }
    }

    private class Sprite {
        public void draw(Graphics graphics, Unit unit) {

        }
    }

    private class Unit {
        Point point {get;}
        Bounds bounds {get;}
        Sprite sprite {get;}
    }

    private class Square : Unit {
        List<Unit> occupants {get;}
    }

    private class Point{
        public int x;
        public int y;
    }

    private class Bounds
    {
        public int width;
        public int height;
    }
}




