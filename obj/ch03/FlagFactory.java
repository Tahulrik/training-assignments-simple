package eu.sig.training.ch03;

import java.awt.Color;
import java.util.Arrays;
import java.util.List;

public interface IFlag
{
    List<Color> getFlagColors();
}

public class DutchFlag : IFlag
{
    List<Color> getFlagColors()
    {
        return new List<Color> {Color.RED, Color.WHITE, Color.BLUE};
    }
}

public class ItalianFlag : IFlag
{
    List<Color> getFlagColors()
    {
        return new List<Color> {Color.GREEN, Color.WHITE, Color.RED};
    }
}

public static class FlagFactory {
    private static Dictionary<Nationality, List<Color>> Flags = new Dictionary<Nationality, List<Color>>();

    // tag::getFlag[]
    public static FlagFactory() {
        Flags[Nationality.DUTCH] = new DutchFlag();
    }

    public List<Color> GetFlagColors(Nationality nationality)
    {
        IFlag flags = Flags[nationality];
        
    }
    // end::getFlag[]

}