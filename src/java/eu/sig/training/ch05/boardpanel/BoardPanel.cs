public class BoardPanel {
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




